namespace AerToss.Areas.Admin.Models
{
    public class AccountViewModel
    {
        public string UserId { get; init; } = null!;
        public string Email { get; init; } = null!;

        public string FullName { get; init; } = null!;

        public string? PhoneNumber { get; init; } = null;
    }
}
