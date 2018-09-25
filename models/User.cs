using System.Collections.Generic;

namespace login_terminal.Models
{
  public class User
  {
    public string UserName { get; set; }
    private string Password { get; set; }

    public bool ValidatePassword(string password)
    {
      return password == Password;
    }

    public User(string username, string password)
    {
      UserName = username;
      Password = password;
    }
  }
}