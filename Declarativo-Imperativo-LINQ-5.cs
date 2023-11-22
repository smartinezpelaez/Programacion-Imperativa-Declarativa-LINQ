using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodigoFacilito_Imperativa_Declarativa
{
    public class Declarativo_Imperativo_LINQ_5 
    {
        //private static void Main(string[] args)
        //{
        //    var users = User.Users();
        //    //Obtener el username y edad  de los usuarios mayores de edad
        //    //cuyo sexo sea femenino
        //    //ordenar el resultado de forma desc  con respecto a su nombre
           
        //    //Enfoque Imperativo
        //    Console.WriteLine("Imperativo");
            

        //    Console.WriteLine("*******************");

        //    //Enfoque Declarativo
        //    Console.WriteLine("Declarativo");

        //    (from u in users
        //    where u.Age < 18
        //    where u.Gender == "male"
        //    orderby u.UserName descending //default es ASC
        //    select new //Generamos un nuevo objeto
        //    {
        //     Nombre = u.UserName,
        //     Edad = u.Age
        //    }           
        //    ).ToList().ForEach(p => Console.WriteLine($"El Usuario es {p.Nombre} y la edad es {p.Edad}"));
          
        //}
    }
}
