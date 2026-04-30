using System.ComponentModel.DataAnnotations;

namespace BookStore.Model
{
    public class Buyer : EFModel
    {
        [Required(ErrorMessage = "Поле LastName обязательно")] 
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Поле Email обязательно")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Поле Phone обязательно")]
        public string? Phone { get; set; }
    }
}
