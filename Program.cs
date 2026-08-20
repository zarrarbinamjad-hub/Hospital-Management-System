using Hospital_Managment_System_Demo;

Doctor d1=new Doctor(1,"Ali","Cardiologist","Six Years");
Doctor d2 = new Doctor(2, "Asif", "Neurologist", "Four Years");
Doctor d3 = new Doctor(3, "Arif", "Dermatologist", "Five Years");
Doctor d4 = new Doctor(4, "Aqeel", "Orthopedic", "Seven Years");
Doctor d5 = new Doctor(5, "Adeel", "Gynecologist", "Eight Years");
d2.Displayinfo();


Console.WriteLine();

Patient p1 = new Patient(1,"Sajid","Heart Disease",23,2000,Gender.Male,d1);
Patient p2 = new Patient(2, "Wajid", "Joints Disease", 24, 2500, Gender.Male, d3);
Patient p3 = new Patient(3, "Majida", "Pregnancy ", 25, 3000, Gender.Female, d5);
Patient p4 = new Patient(4, "Bashir", "Heart Disease", 26, 4000, Gender.Male, d1);
Patient p5 = new Patient(5, "Sartaj", "Bones Disease", 27, 2500, Gender.Male, d4);
Patient p6 = new Patient(6, "Sohail", "Brain Disease", 28, 2800, Gender.Male, d2);
Patient p7 = new Patient(7, "Ashfaq", "Joints Disease", 29, 3500, Gender.Male, d3);
Patient p8 = new Patient(8, "Bilal", "Bones Disease", 30, 3800, Gender.Male, d4);
Patient p9 = new Patient(9, "Hamza", "Brain Disease", 32, 2000, Gender.Male, d2);
Patient p10 = new Patient(10, "Omar", "B.P Disease", 33, 3000, Gender.Male, d1);
p1.Displayinfo();
p2.Displayinfo();


Console.WriteLine();

Hospital h1 = new Hospital("Hayatabad Medical Complex","Peshawar");
h1.info();
h1.AddDoctor(d1);
h1.AddDoctor(d2);
h1.AddDoctor(d3);
h1.AddDoctor(d4);
h1.AddDoctor(d5);
h1.AllDoctors();
Console.WriteLine();
h1.AddPatient(p1);
h1.AddPatient(p2);
h1.AddPatient(p3);
h1.AddPatient(p4);
h1.AddPatient(p5);
h1.AddPatient(p6);
h1.AddPatient(p7);
h1.AddPatient(p8);
h1.AddPatient(p9);
h1.AddPatient(p10);
h1.AllPatients();
h1.HighestBill();
h1.LowestBill();
h1.SearchPatient(2);
h1.SearchDoctor("Ali");
h1.TotalHospitalEarning();
h1.YoungestPatient();
h1.OldestPatient();




