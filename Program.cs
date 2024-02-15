// See https://aka.ms/new-console-template for more information
using WelcomeApp1;

Console.WriteLine("Hello, World! Welcome to Authentication App");
Signin obj = new Signin();
Console.WriteLine(obj.Authenticate("admin","admin"));
