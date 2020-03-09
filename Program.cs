using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Programer gates = new Programer() { name = "Vasya" };
           
            ValidateLevel(gates);

            void ValidateLevel(Object manName)
            {
                
                Type t = manName.GetType();
                
                object[] attributes = t.GetCustomAttributes(typeof(AccessLevelAttribute), true);
                foreach (AccessLevelAttribute d in attributes)
                {
                    if(d.Level == 1)
                    {
                        Console.WriteLine("You have highest level of access");
                    }

                    if (d.Level == 2)
                    {
                        Console.WriteLine("You have level of programmer");
                    }
                    else
                    {
                        Console.WriteLine("You have lowest level of access");
                    }
                }

            }
            Console.ReadLine();
            
        }
    }

    [AccessLevelAttribute(3)]
    class Manager
    {
        public string name;
       

    }

    [AccessLevelAttribute(2)]
    public class Programer
    {
        public string name;
        
    }

    [AccessLevelAttribute(1)]
    public class Director
    {
        public string name;
       
    }

    public class AccessLevelAttribute : System.Attribute
    {
        public int Level { get; set; }

        public AccessLevelAttribute(int level)
            {
            Level = level;
            }


    }

   
}
