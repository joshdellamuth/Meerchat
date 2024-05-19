using Meerchat.Api.Core.Common;

namespace Meerchat.Api.Core.Entities
{
    public class UserEntity : BaseEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;   
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ProfilePicturePath { get; set; }
    }
}
