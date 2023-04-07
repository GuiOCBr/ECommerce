using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceModels
{
    public class DeliveryAddress
    {

        //endereçoEntrega.usuario.nome
        public int Id { get; set; }

        public int UserId { get; set; }

        public string?  NameAddress {get;set;}

        public string? CEP { get; set; }

        public string? State { get; set; }

        public string? City { get; set; }

        public string? Neighborhood { get; set; }

        public string? Address { get; set; }

        public int? Number { get; set; }

        public string? Complement { get; set; }

       public User? User { get; set; }

    }
}
