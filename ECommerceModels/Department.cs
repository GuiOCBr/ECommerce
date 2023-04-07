using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceModels
{
    public class Department
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<User>? User { get; set; }



    }
}
