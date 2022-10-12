using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Läkare läkare = new Läkare();

            Sjuksköterska sjuksköterska = new Sjuksköterska();
            sjuksköterska.BloodType();

            Patient patient = new Patient();
            patient.firstname = "Calle";
            patient.lastname = "Svensson";
            Console.WriteLine(patient.firstname + " " + patient.lastname);

            Console.ReadLine();
        }
    }
    public class Person
    {
        int age 
        { 
            get { return age; }
            set
            {
                if (age != 0)
                {
                    age = value;
                }
                else 
                {
                    Console.WriteLine("Fel värde");
                }
            } 
        }
        public string firstname;
        public string lastname;
        string sex 
        { 
            get { return sex; } 
            set
            {
                if(sex == "Male" || sex == "Female" || sex == "Other")
                {
                    sex = value;
                }
                else
                {
                    sex = "Other";
                }
            }
        }
        
    }
    public class Läkare : Person
    {

        string skrivrecept;
        double salary
        {
            get
            {
                int TimPris = 500;
                salary = WorkTime * TimPris;
                return salary; 
            }
            set
            {
                salary = value;
            }
            
        }
        double WorkTime { get; set; } = 40; //<-- autoproperty
    }
    public class Sjuksköterska : Person
    {
        public void BloodType()
        {
            Random BloodType = new Random();
            int Type = BloodType.Next(0, 3);
            if (Type == 0)
            {
                Console.WriteLine("Blodtype A");  
            }
            else if (Type == 1)
            {
                Console.WriteLine("Blodtype B");
            }
            else if (Type == 2)
            {
                Console.WriteLine("Blodtype 0");
            }
        }
    }
    public class Patient : Person
    {
        string SjukDom = "Corona";
        string TimeofReg = "Idag";
    }
}
