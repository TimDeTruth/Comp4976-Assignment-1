using System.ComponentModel.DataAnnotations;

namespace Models;

public class User
{

  public enum UserRole
  {
    Admin,
    BoardMember
  }

  [Key]
  public int UserId { get; set; }
  public UserRole? Role { get; set; }
  public string? Username { get; set; }
}