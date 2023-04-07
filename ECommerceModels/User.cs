namespace ECommerceModels
{
    public class User
    {
        // usuario.contato.telefone

        //usuario.endereçoentrega[] - pode pegar por varios endereços 
        public int Id { get; set; } // necessário para modelagem de relacionamento

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Sex { get; set; }

        public string? RG { get; set; }

        public string? CPF { get; set; }

        public string? NameMother { get; set; }

        public string? StatusRegistration { get; set; }

        public DateTimeOffset DataRegister { get; set; }


        //  são  os relacionamentos 
        public Contact? Contatact { get; set; } // necessário para POO

        public ICollection<DeliveryAddress> DeliveryAddress { get; set; }

        public ICollection<Department>? Department { get; set; }

    }
}
