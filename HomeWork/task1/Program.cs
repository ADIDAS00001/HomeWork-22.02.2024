
using task1;
var rec = new Rectangle();
System.Console.Write("Widht = ");
rec.Width=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Height = ");
rec.Height=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Color = ");
rec.Color=Console.ReadLine();
System.Console.Write("Area = ");
System.Console.WriteLine(rec.GetArea());
System.Console.Write("Perimeter = ");
System.Console.WriteLine(rec.GetPerimeter());
