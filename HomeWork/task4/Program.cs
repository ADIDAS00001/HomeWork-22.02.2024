


using task4;
var country =new Country("Tajikistan","Dushanbe",9.537645,"Tajik");
System.Console.WriteLine(country.GetName());
System.Console.WriteLine(country.GetCapital());
country.SetPopulation(9.537645);
System.Console.WriteLine($"Population: {country.GetPopulation()}");
System.Console.WriteLine(country.GetOfficialLanguag());

System.Console.WriteLine("------------------------");
var country1 =new Country("Canada","Ottava",30.923694,"English");
System.Console.WriteLine(country1.GetName());
System.Console.WriteLine(country1.GetCapital());
country1.SetPopulation(30.923694);
System.Console.WriteLine($"Population: {country1.GetPopulation()}");
System.Console.WriteLine(country1.GetOfficialLanguag());