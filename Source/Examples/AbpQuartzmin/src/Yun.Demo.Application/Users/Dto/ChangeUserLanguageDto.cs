using System.ComponentModel.DataAnnotations;

namespace Yun.Demo.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}