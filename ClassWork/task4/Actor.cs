namespace task4;

public class Actor
{
    string? _fullName;
    int _age;
    string? _gender;
    List<string> moviesPlayed = new List<string>();
    public Actor(){}
    public Actor(string name,int age,string gender)
    {
        _fullName=name;
        _age=age;
        _gender=gender;
    }
    public string GetName()
    {
        return _fullName;
    }
    public void AddMovie(string movietitle)
    {
        moviesPlayed.Add(movietitle);
    }
    public List<string> GetMoviesPlayed()
    {
        return moviesPlayed;
    }
    public void SetAge(int age)
    {
        _age=age;
    }
    public int GetAge()
    {
        return _age;
    }
    public void SetGender(string gender)
    {
        _gender=gender;
    }
    public string GetGender()
    {
        return _gender;
    }

}
