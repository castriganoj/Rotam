using System.ComponentModel.DataAnnotations;

namespace Rotam.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}