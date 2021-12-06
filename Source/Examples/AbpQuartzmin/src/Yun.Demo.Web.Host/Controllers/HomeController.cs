using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using Yun.Demo.Controllers;
using Abp.Quartz;
using Quartz;

namespace Yun.Demo.Web.Host.Controllers
{
    public class HomeController : DemoControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;
        private readonly IQuartzScheduleJobManager _jobManager;
        public HomeController(INotificationPublisher notificationPublisher, IQuartzScheduleJobManager jobManager)
        {
            _notificationPublisher = notificationPublisher;
            _jobManager = jobManager;
        }

        public IActionResult Index()
        {
            return Redirect("/swagger");
        }

        /// <summary>
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// Don't use this code in production !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "This is a test notification, created at " + Clock.Now;
            }

            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);

            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }

        public async Task<ActionResult> ScheduleJob()
        {
            await _jobManager.ScheduleAsync<MyLogJob>(
                job =>
                {
                    job
                    .WithIdentity("MyLogJobIdentity", "MyGroup")
                        .WithDescription("A job to simply write logs.");
                },
                trigger =>
                {
                    trigger.StartNow()
                        .WithSimpleSchedule(schedule =>
                        {
                            schedule.RepeatForever()
                                .WithIntervalInSeconds(50)
                                .Build();
                        });
                });

            return Content("OK, scheduled!");
        }
    }
}
