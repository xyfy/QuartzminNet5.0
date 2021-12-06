using Yun.Demo.Debugging;

namespace Yun.Demo
{
    public class DemoConsts
    {
        public const string LocalizationSourceName = "Demo";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "42631a0d22344e95aebfc25d692a91ce";
    }
}
