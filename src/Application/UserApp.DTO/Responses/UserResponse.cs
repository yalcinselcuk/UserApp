using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.DTO.Responses
{
    public class UserResponse
    {
        public int Id { get; set; }

        [Required]

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
    }
}
