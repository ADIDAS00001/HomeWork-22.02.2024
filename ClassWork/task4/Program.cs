


using task4;

var actor=new Actor("Robert Downey Jr",56,"Male");
System.Console.WriteLine($"Actor's Name: {actor.GetName()}.");
System.Console.WriteLine($"Age: {actor.GetAge()}");
System.Console.WriteLine($"Gender: {actor.GetGender()}");
System.Console.WriteLine($"Movies Played by {actor.GetName()}.:");
actor.AddMovie("Iron Man");
actor.AddMovie("Avengers: Endgame");
actor.AddMovie("Sherlock Holmes");
var i=1;
foreach (var item in actor.GetMoviesPlayed())
{
    System.Console.WriteLine($"{i}. {item}");
    i++;
}