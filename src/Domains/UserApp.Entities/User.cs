using System.ComponentModel.DataAnnotations;

namespace UserApp.Entities
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }

    }
}