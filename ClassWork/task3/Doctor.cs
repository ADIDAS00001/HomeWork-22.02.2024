namespace task3;

public class Doctor
{
    string? _fullName;
    string? _specialty;
    int _experience;
    string? _medicament;
    public Doctor(){}
    public Doctor(string name,string specialty)
    {
        _fullName=name;
        _specialty=specialty;
    }
    public Doctor(string name,string specialty,int experience,string medicament)
    {
        _fullName=name;
        _specialty=specialty;
        _experience=experience;
        _medicament=medicament;
    }
    public string GetName()
    {
        return $"Doctor's Name: {_fullName}";
    }
    public string GetSpeciality()
    {
        return $"Medical Specialty: {_specialty}";
    }

    public string TreatPatient(string patientName)
    {
        return $"{_fullName} is performing a medical examination for the patient named {patientName}";
    }
    public string PerformMedicalExamination(string patientName)
    {
        return $"{_fullName} prescribes {_medicament} for the patient named {patientName}";
    }
    public string PrescribeMedication(string patientName, string medication)
    {
        return $"{_fullName} prescribes {medication} for the patient named {patientName}";
    }
    public void SetExperience(int years)
    {
        _experience=years;
    }
    public int GetExperience() 
    {
        return _experience;
    }

}
