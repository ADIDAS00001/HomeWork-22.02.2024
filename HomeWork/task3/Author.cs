namespace task3;

public class Author
{
    string? _name;
    int _age;
    string? _nationality;
    public Author(){}
    public Author(string name,int age,string nationality)
    {
        _name=name;
        _age=age;
        _nationality=nationality;
    }
    public Author(string name,int age)
    {
        _name=name;
        _age=age;
    }
    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    public string GetNatoinality()
    {
        return _nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"My name is {_name}.\nI am {_age} years old.\nI am from {_nationality}.");
    }
    public void CelebrateBirthday()
    {
        _age+=1;
    }



}
