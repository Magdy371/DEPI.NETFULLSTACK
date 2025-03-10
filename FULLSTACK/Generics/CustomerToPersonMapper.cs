using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CustomerToPersonMapper : IMapper<Person, Customer>
    {
        public Person Map(Customer source)
        {
            return new Person
            {
                Id = source.Id,
                Name = source.Name,
                Age = source.Age
            };

        }
    }
}