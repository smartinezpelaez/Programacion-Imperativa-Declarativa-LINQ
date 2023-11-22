using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFacilito_Imperativa_Declarativa
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }


        public static List<User> Users()
        {
            return new List<User> 
            {

                new User { Id = 1, UserName = "Steven", Age = 38, Gender = "male" },
                new User { Id = 1, UserName = "Vanessa", Age = 39, Gender = "female" },
                new User { Id = 1, UserName = "Valeria ", Age = 16, Gender = "female" },
                new User { Id = 1, UserName = "Thiagp", Age = 7, Gender = "male" },

            };


        }

    }

    
}
