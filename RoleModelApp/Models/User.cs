using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(64)]
    public string PasswordHash { get; set; } = string.Empty;

    [Required]
    [MaxLength(36)]
    public string Salt { get; set; } = string.Empty;

   
    public bool IsBlocked { get; set; } = false;

    public bool RequirePunctuation { get; set; } = false;
    public bool RequireLetter { get; set; } = false;

    public int MinPasswordLength { get; set; } = 0;

    public int PasswordExpiryMonths { get; set; } = 0;

    public DateTime? PasswordSetUtc { get; set; }

    public bool IsAdmin => Username.Equals("ADMIN", StringComparison.OrdinalIgnoreCase);
}