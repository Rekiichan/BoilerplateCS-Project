using System.ComponentModel.DataAnnotations;

namespace MyPrjTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}