using System;
using System.Collections.Generic;
using login_terminal.Models;

namespace login_terminal
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, User> user = new Dictionary<string, User>() {
      {"Test", new User("Test", "Test1")},
      {"Mike", new User("Mike", "Mike1")}
      };
      Console.Clear();
      Console.WriteLine("Please log in to continue!");
      Console.Write("UserName: ");
      string username = Console.ReadLine();
      Console.Write("Password: ");
      string password = Console.ReadLine();
      if (user.ContainsKey(username) && user[username].ValidatePassword(password))
      {
        System.Console.WriteLine("welcome friend");
      }
      else
      {
        System.Console.WriteLine("bad creds");
      }
    }
  }
}
