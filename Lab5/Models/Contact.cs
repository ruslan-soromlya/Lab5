using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [DisplayName("Ім'я")]
        public string FirstName { get; set; }
        [DisplayName("Прізвище")]
        public string LastName { get; set; }
        [DisplayName("Адреса")]
        public string Address { get; set; }
        [DisplayName("Пошта")]
        public string Email { get; set; }
        [DisplayName("Телефон")]
        public string PhoneNumber { get; set; }
        [DisplayName("Мобільний Телефон")]
        public string MobilePhoneNumber { get; set; }

    }
}
