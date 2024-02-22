namespace task2;

public class Student
{
    string? _fullName;
    int _age;
    int _grade;
    public Student(){}
    public Student(string name,int age)
    {
        _fullName=name;
        _age=age;
    }
    public Student(string name,int age,int grade)
    {
        _fullName=name;
        _age=age;
        _grade=grade;
    }
    public void Study()
    {
        System.Console.WriteLine($"{_fullName} is is studying.");
    }
    public void SetGrade(int newGrade)
    {
        _grade=newGrade;
    }
    public int GetGrade()
    {
        return _grade;
    }

}
