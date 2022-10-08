namespace SamoleAPI.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

         public string MobileNumber { get; set; }

        public string AltMobileNumber { get; set; }

        public string Email { get; set; }

        public string Passoword { get; set; }

        public int? Role { get; set; }

        public string Token { get; set; }

        public sbyte? EmailVerified { get; set; }

        public sbyte? MobileVerified { get; set; }

        public sbyte? WrongAttempts { get; set; }

        public string PassCode { get; set; }

        public bool UserVerfied { get; set; }

        public sbyte? Disabled { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastEditDate { get; set; }

        public string LastEditedBy { get; set; }
        public sbyte? Active { get; set; }

    }
}
