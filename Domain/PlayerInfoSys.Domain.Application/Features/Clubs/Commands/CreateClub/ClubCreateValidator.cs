namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.CreateClub
{
    public class ClubCreateValidator : AbstractValidator<ClubCreateCommand>
    {
        public ClubCreateValidator()
        {
            RuleFor(c => c.CreateClubRequest.Name)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
            RuleFor(c => c.CreateClubRequest.Country)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
        }
    }
}
