namespace MyProject
{
    public class User
    {
        public User()
        {
            
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        private int legalAge = 18;
        public bool ForAdult()
        {
            if(Age < legalAge)
                return false;

            return true;
        }
    }
}

