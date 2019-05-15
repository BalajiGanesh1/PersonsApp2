using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
    {
     class Person
        {
        public string FirstName;
        public string LastName;
        public string flag;
        public int age;


        }

     class Program
        {
        static void Main(string[] args)
            {
                    var AllPersons = new List<Person>
                    {

                    new Person{FirstName="MS",LastName="Dhoni",age=37,flag=null},
                    new Person{FirstName="Sunil",LastName="Gavaskar",age=62,flag=null},
                    new Person{FirstName="Virat",LastName="Kohli",age=30,flag=null},
                    new Person{FirstName="Sam",LastName="Curran",age=18,flag=null},
                    new Person{FirstName="Kagiso",LastName="Rabada",age=19,flag=null},
                    new Person{FirstName="Rishabh",LastName="Pant",age=21,flag=null},
                    new Person{FirstName="Imran",LastName="Tahir",age=41,flag=null},
                    new Person{FirstName="VB",LastName="Chandrasekhar",age=67,flag=null},
                    new Person{FirstName="Suresh",LastName="Raina",age=32,flag=null},
                    new Person{FirstName="Sachin",LastName="Tendulkar",age=41,flag=null}

                    };
            
            void SeniorCitizensIdentifier()
                    {

                    Console.WriteLine("These are the Senior Citizens\n");
           

                    foreach (var person in AllPersons)
                    {
                      if(person.age>=60)
                      {

                        Console.WriteLine(person.FirstName + " " + person.LastName);

                      }


                    }
               



                    }

            void AnotherFunction()
                {

                Console.WriteLine("First 5 Students are \n");
                for(var i=0;i<5;i++)
                {
                    Console.WriteLine(AllPersons[i].LastName);


                }



                foreach (var person in AllPersons)
                    {

                    person.flag = person.age >= 13 && person.age <= 19 ? "Teenager" : null ;
                    person.flag = person.flag ?? "No";



                    }

                Console.WriteLine("\nThese are the Teenagers  \n");
                foreach (var person in AllPersons)
                {
                    if(person.flag=="Teenager")
                    Console.WriteLine(person.FirstName + person.LastName + "  whose age is  " +person.age+"  With updated flag value  " + person.flag);

                }

                

                }

            SeniorCitizensIdentifier();
            AnotherFunction();
            Console.ReadKey();
              
            }
        }
    }
