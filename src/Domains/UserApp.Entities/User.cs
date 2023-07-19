using System.ComponentModel.DataAnnotations;

namespace UserApp.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }

    }
}