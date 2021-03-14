using MediatR;

namespace CleanCodePOC.Processes
{
    public class SaveUser : IRequest<SaveUserResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsPasswordChangeRequired { get; set; }
        public bool IsEmailAddressVerified { get; set; }
        public bool IsMobileNumberVerified { get; set; }
    }

    public class SaveUserResult
    {
        public string Username { get; set; }
    }
}
