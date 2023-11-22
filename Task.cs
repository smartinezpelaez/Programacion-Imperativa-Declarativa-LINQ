using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoFacilito_Imperativa_Declarativa
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UserId { get; set; }

        public Task(int id, string titulo, int userId)
        {
            this.Id = id;
            this.Title = titulo;
            this.UserId = userId;            
        }

        public static List<Task> Tasks() 
        {
            return new List<Task>
            {
                new Task (1, "Terminar tarea", 1),
                new Task (2, "Ir al supermercado", 6),
                new Task (3, "Finalizar de estudiar", 2),
                new Task (4, "Formatear Pc", 2),
                new Task (5, "Limpiar casa", 1)           
            
            };
        }
    }
}
