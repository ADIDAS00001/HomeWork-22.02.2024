namespace task4;

public class Country
{
    string? _name;
    string? _capital;
    double _population;
    string?  _officialLanguage;
    public Country(string name,string capital,double pop,string officialLanguage)
    {
        _name=name;
        _capital=capital;
        _population=pop;
        _officialLanguage=officialLanguage;
    }
    public string GetName()
    {
        return $"Country Name: {_name}";
    }
    public void SetCapital(string capital) => _capital=capital;
    public string GetCapital(){ return $"Capital: {_capital}";}
    public void SetPopulation(double pop) => _population=pop;
    public double GetPopulation(){ return _population;}
    public void SetOfficialLanguage(string language) => _officialLanguage=language;
    public string GetOfficialLanguag(){ return $"Official Language: {_officialLanguage}";}





}
