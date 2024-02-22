namespace task2;

public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public bool IsLoggedIn { get; set; }

    public void Login(string username,string pass)
    {
        if(UserName==username && Password==pass)
        {
            System.Console.WriteLine("User logged in successfully");
            IsLoggedIn=true;
        }
        else
        {
            System.Console.WriteLine("Your password or username is incorrect");
        }
    }
    public void LogOut()
    {
        IsLoggedIn=false;
    }
    public string GetFullName()
    {
        return $"{FirstName} {LastName} {IsLoggedIn}";
    }
}
