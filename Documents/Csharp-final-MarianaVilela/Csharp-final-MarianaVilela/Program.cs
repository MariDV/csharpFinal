using System;
using System.Net;
using Newtonsoft.Json;


namespace CsharpfinalMarianaVilela
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            JsonStudents();
            Console.ReadLine();
        }
        static void JsonStudents()
        {
            WebClient students = new WebClient();
            string estudantes = students.DownloadString("http://www.json-generator.com/api/json/get/bPCtVMPmNu?indent=0");
            Student[] aluno = JsonConvert.DeserializeObject<Student[]>(estudantes);
            //transform json information to object 
            //now that is an array, using a for loop I can call all the students index[i] -> aluno[i]

            for (int i = 0; i < aluno.Length; i++)
            {
                aluno[i].Greeting();
            }

        }
    }
}
