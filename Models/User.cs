using System.ComponentModel.DataAnnotations;

namespace Models;

public class User {
	[Key]
	public int UserId { get; set; }
	public char? Role { get; set; }
	public string? Username { get; set; }
}                                           