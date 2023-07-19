using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApp.DTO.Requests
{
    public class CreateNewUserRequest
    {
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
    }
}
