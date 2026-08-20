using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Managment_System_Demo
{
    public class Patient
    {
        public int id;
        public int ID 
        {
            get { return id; }
            set { id = value; }
        }
        public string Name { get; set; }
        public string Disease { get; set; }
        public int Age { get; set; }
        public double Bill {  get; set; }
        public Gender gender { get; set; }
        public Doctor doctor { get; set; }


        public Patient(int id,string name,string disease,int age,double bill,Gender gender,Doctor doctor )
        {
                ID= id;
            Name = name;
            Disease = disease;
            Age = age;
            Bill = bill;
            this.gender =gender;
            this.doctor =doctor;
        }

    
        
        public void Displayinfo()
        {
            Console.WriteLine("Patient ID: " + ID);
            Console.WriteLine("Patient Name: " + Name);
            Console.WriteLine("Patient Age: "+Age);
            Console.WriteLine("Bill: "+Bill); 
            Console.WriteLine("Gender: "+ gender); 
            Console.WriteLine("Doctor: " + doctor.Name);
        }

    }
}
