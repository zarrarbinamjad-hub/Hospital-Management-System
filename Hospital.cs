using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Managment_System_Demo
{
    public class Hospital
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Hospital(string name, string location)
        {
            Name = name;
            Location = location;
        }

        Patient[] patients = new Patient[10];
        private int patientcount = 0;
        Doctor[] doctors = new Doctor[5];
        private int doctorcount = 0;

        public void AllDoctors()
        {
            for (int i = 0; i < doctorcount; i++)
            {
                doctors[i].Displayinfo();
            }
        }
        public void AllPatients()
        {
            for (int i = 0; i < patientcount; i++)
            {
                patients[i].Displayinfo();
            }
        }

        public void AddPatient(Patient patient)
        {
            patients[patientcount] = patient;
            patientcount++;
        }
        public void AddDoctor(Doctor doctor)
        {
            doctors[doctorcount] = doctor;
            doctorcount++;
        }

        public void HighestBill()
        {
            double highbill = patients[0].Bill;
            string Name = patients[0].Name;
            for (int i = 0; i < patientcount; i++)
            {
                if (  patients[i].Bill>highbill)
                {
                    highbill = patients[i].Bill;
                    Name= patients[i].Name;
                }
            }
            Console.WriteLine("Patient Name: " + Name);
            Console.WriteLine("Highest Bill: "+highbill);
        }

        public void LowestBill()
        {
            double lowestbill = patients[0].Bill;
            string Name = patients[0].Name;
            for (int i = 0; i < patientcount; i++)
            {
                if (patients[i].Bill < lowestbill)
                {
                    lowestbill = patients[i].Bill;
                    Name = patients[i].Name;
                }
            }
            Console.WriteLine("Patient Name: " + Name);
            Console.WriteLine("Lowest  Bill: " + lowestbill);
        }

        public void SearchPatient(int id)
        {
            for (int i = 0;i < patientcount;i++)
            {
                if (id == patients[i].ID)
                {
                   
                    patients[i].Displayinfo();
                }
            }
            Console.WriteLine("Patient Not Found");

        }

        public void TotalHospitalEarning()
        {
            double count = 0;
            for (int i = 0; i < patientcount; i++)
            {
                count = count+patients[i].Bill;
               
            }
            Console.WriteLine("Total Earning: "+count);
        }
        public void SearchDoctor(string Name)
        {
            for (int i = 0; i < doctorcount; i++)
            {
                if (Name == doctors[i].Name)
                {
                    doctors[i].Displayinfo();
                }

            }
            Console.WriteLine("Doctor Not Found");
        }
        public void YoungestPatient()
        {
            int Age = patients[0].Age;

            for (int i = 0; i <patientcount; i++)
            {
                if (patients[i].Age < Age)
                {
                    Age= patients[i].Age;
                }
            }
            Console.WriteLine("The Youngest Patient Age is: "+Age);

        }
        public void OldestPatient()
        {
            int Age = patients[0].Age;

            for (int i = 0; i < patientcount; i++)
            {
                if (patients[i].Age > Age)
                {
                    Age = patients[i].Age;
                }
            }
            Console.WriteLine("The Oldest Patient Age is: " + Age);
        }
        public void info()
        {
            Console.WriteLine("Hospital Name: "+ Name); 
            Console.WriteLine("Hospital location: " + Location);
        }
    }
}
