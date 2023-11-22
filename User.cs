namespace CodigoFacilito_Imperativa_Declarativa
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public User(int id, string userName, int age, string gender)
        {
            this.Id = id;
            this.UserName = userName;   
            this.Age = age;
            this.Gender = gender;                
        }

        public static List<User> Users()
        {
            return new List<User> 
            {

                new User (1, "Steven",  38,  "male" ),
                new User (2, "Vanessa",  39,  "female" ),
                new User (3, "Valeria", 16,  "female" ),
                new User (4, "Thiago",  7,  "male"),
                new User (5, "Silvio",  48,  "male"),
                new User (6, "Nora",  62,  "female")
            };
        }

    }

    
}
