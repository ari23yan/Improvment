using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person
    {
        public Guid id { get; set; }
        public string? Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

    }
}
