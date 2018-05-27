using System.ComponentModel.DataAnnotations;

namespace Xn.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}