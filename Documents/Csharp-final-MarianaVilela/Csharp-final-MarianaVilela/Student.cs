using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace CsharpfinalMarianaVilela

{
    public class Student : Person, IUpdatable
    {

        public Dictionary<string, bool> Skillset { get; set; } = new Dictionary<string, bool>(); //create a new dictionary and 'inform' what kind of data is there..(bool and string) 
         //all this info will come from Json
        /* "CSS3":true,
         "VB":true,
         "Java":false,
         "Inroduction to Network":false,
         "C#":true,
         "JavaScript":true,
         "C":true,
         "C++":true,
         "ASP.NET":false,
         "HTML5":true,
         "SQL":true,
         "PHP":false*/

        public string Program { get; set; }
        public string Start_Date { get; set; } //use as a string because Im 'importing' this from json, not generating a new info

        public void Update_Date() //making datatime more beautiful 
        {
            Console.WriteLine($"Updated : {DateTime.Now.ToString("MMMM dd, yyyy")}");
        }

        public override void Greeting()
        {
            //use this to call all information i 'imported' from json...
            Console.WriteLine("######################################################################## \n");
            Console.WriteLine("Hello, I am " + this.Name + this.Last_Name);
            Console.WriteLine("My email is " + this.Email);
            Console.WriteLine("I have started " + this.Start_Date + " at " + this.Program + " in ITD Canada");
            Console.WriteLine("I am able to develop code in the following programming languages :" );
           
            foreach (var item in Skillset)
            { //check all values in my skillset dictionary, if they are true, print it...
                if(item.Value)
                    Console.Write(item.Key + "  " );
                }
            Console.WriteLine("\n");
            Update_Date(); //here Im calling the function/method Update_Date () -- use to generate the correct format...
            Console.WriteLine("\n######################################################################## \n");
        }
        //prints all information from json

        }

    }


