using System;
namespace CsharpfinalMarianaVilela
{
    public abstract class Person
    {

        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        public Person(string Name, string Last_Name, string Email)
        {
            this.Name = Name;
            this.Last_Name = Last_Name;
            this.Email = Email;
        }

        //constructor
        public Person()
        {
            Name = "Jose Lucas";
            Last_Name= "Neves Ferreira";
            Email = "iamjose@zemail.com";
        }

        public virtual void Greeting() {
            Console.WriteLine($"First Name: {Name}; \n Last Name: {Last_Name}; \n Email: {Email}");
        } //prints Name, Last_Name, and Email
    }
}
