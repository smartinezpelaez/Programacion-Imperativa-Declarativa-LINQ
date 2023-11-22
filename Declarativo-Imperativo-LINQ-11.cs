namespace CodigoFacilito_Imperativa_Declarativa
{
    public class Declarativo_Imperativo_LINQ_11
    {
        private static void Main(string[] args)
        {
            var users = User.Users();
            var tasks = Task.Tasks();
       
            //var numeros = new List<int>() { 10,8,7,6,4,5,2,1,10};
            //Obtener el Username de los usuarios que No tengan tareas
            //Left Join


            //Enfoque Imperativo
            Console.WriteLine("Imperativo");
            

            Console.WriteLine("*******************");

            //Enfoque Declarativo
            Console.WriteLine("Declarativo");

            var q = (from u in users
                     join t in tasks on u.Id equals t.UserId into relacion // crea el objeto relacion
                     from a in relacion.DefaultIfEmpty()
                     where a == null //Donde es nulo
                     select u.UserName).ToList();
            foreach ( var u in q ) { Console.WriteLine(u); }


        }
    }
}
