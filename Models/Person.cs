namespace Competition2.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }

        public abstract void DisplayInfo();
    }
}
