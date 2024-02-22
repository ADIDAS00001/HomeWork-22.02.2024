


using task3;


var doc = new Doctor("Dr. Johnson","Cardiologist",15,"Antibiotics");
System.Console.WriteLine(doc.GetName());
System.Console.WriteLine(doc.GetSpeciality());
System.Console.Write($"Years of Experience: ");
System.Console.WriteLine(doc.GetExperience());
System.Console.WriteLine(doc.TreatPatient("Emily Parker"));
System.Console.WriteLine(doc.PerformMedicalExamination("Emily Parker"));
System.Console.WriteLine(doc.PrescribeMedication("James Brown","Antibiotics"));
