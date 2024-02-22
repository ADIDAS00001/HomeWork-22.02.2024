
using task2;

var user=new User();
user.FirstName="Muhammad";
user.LastName="Samadov";
user.UserName="SamadovMuhammad";
user.Password="Muhammad";
user.IsLoggedIn=false;
user.Login("SamadovMuhammad","Muhammad");
System.Console.WriteLine(user.GetFullName());