using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Managment_System_Demo
{
    public class Doctor
    {
        private int id;
        public int ID 
        {
            get { return id; }
            set { id = value; } 
        }
        public string Name {  get; set; }
        public string Specialization {  get; set; }
        public string Experience {  get; set; }

        public Doctor(int id,string name,string specialization,string experience)
        {
            ID= id;
            Name= name;
            Specialization= specialization;
            Experience= experience;

        }
        public void Displayinfo()
        {
            Console.WriteLine("Doctor Name: " + Name);
            Console.WriteLine("Doctor ID: "+id);
            Console.WriteLine("Specialization: "+Specialization);
            Console.WriteLine("Experience: "+Experience); 
        }

    }
}
