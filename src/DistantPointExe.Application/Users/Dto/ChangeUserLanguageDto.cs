using System.ComponentModel.DataAnnotations;

namespace DistantPointExe.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}