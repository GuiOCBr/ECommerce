using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceModels
{
    public  class Contact
    {
        //contact.user.nome
        public int Id { get; set; }

        public string? UserId { get; set; }

        public string? Telephone { get; set; }

        public string? CellPhone { get; set; }

        public User? User { get; set; } // necessário para POO

    }
}
