namespace CodigoFacilito_Imperativa_Declarativa
{
    public class Declarativo_Imperativo_LINQ_9
    {
        //private static void Main(string[] args)
        //{
        //    var users = User.Users();
        //    var tasks = Task.Tasks();
       
        //    //Obtener la cantidad de tareas por cada usuario
        //    //El resultado debe  estar ordenado por la cantidad de tareas orden desc


        //    //Enfoque Imperativo
        //    Console.WriteLine("Imperativo");
            

        //    Console.WriteLine("*******************");

        //    //Enfoque Declarativo
        //    Console.WriteLine("Declarativo");

        //       var q = (from u in users
        //               join t in tasks on u.Id equals t.UserId
        //               group u by u.UserName into groupUser
        //               orderby groupUser.Count() descending
        //               select new 
        //               {
        //                 Message = "UserName : " + groupUser.Key + " Cantidad de tareas : " + groupUser.Count()
        //               }).Distinct().ToList();
        //       foreach ( var u in q ) { Console.WriteLine(u.Message); }


        //    Console.WriteLine("*******************");
        //    //Enfoque Declarativo
        //    Console.WriteLine("Declarativo");

        //    var j = (from u in users
        //             join t in tasks on u.Id equals t.UserId                                  
        //             select u.UserName).ToList();
        //    foreach (var u in j) { Console.WriteLine(u); }


        //}
    }
}
