using Moongazing.Core.Persistence.Repositories;
using Moongazing.TaskHub.Domain.Enums;

namespace Moongazing.TaskHub.Domain.Entities;

public class UserEntity : Entity<int>,
{
    public string Cd_Operatore { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
    public AuthenticatorType AuthenticatorType { get; set; }
    public string? UserIns { get; set; }
    public string? UserUpd { get; set; }
    public DateTime? TimeIns { get; set; }
    public DateTime? TimeUpd { get; set; }
    public virtual ICollection<UserOperationClaimEntity> UserOperationClaims { get; set; } = new HashSet<UserOperationClaimEntity>();
    public virtual ICollection<RefreshTokenEntity> RefreshTokens { get; set; } = new HashSet<RefreshTokenEntity>();
    public virtual ICollection<EmailAuthenticatorEntity> EmailAuthenticators { get; set; } = new HashSet<EmailAuthenticatorEntity>();
    public virtual ICollection<OtpAuthenticatorEntity> OtpAuthenticators { get; set; } = new HashSet<OtpAuthenticatorEntity>();
    public virtual ICollection<VBSconTEntity> VBSconT { get; set; } = new HashSet<VBSconTEntity>();
    public virtual ICollection<VBCassaMVEntity> VBCassaMV { get; set; } = new HashSet<VBCassaMVEntity>();

    public UserEntity()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        PasswordHash = [];
        PasswordSalt = [];
        Cd_Operatore = string.Empty;
    }

    public UserEntity(
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType,
        string cd_operatore
    )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
        Cd_Operatore = cd_operatore;
    }

    public UserEntity(
        int id,
        string firstName,
        string lastName,
        string email,
        byte[] passwordSalt,
        byte[] passwordHash,
        bool status,
        AuthenticatorType authenticatorType,
        string cd_operatore
    )
        : base()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
        AuthenticatorType = authenticatorType;
        Cd_Operatore = cd_operatore;
    }
}