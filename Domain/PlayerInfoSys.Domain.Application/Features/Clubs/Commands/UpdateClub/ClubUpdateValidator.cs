namespace PlayerInfoSys.Domain.Application.Features.Clubs.Commands.UpdateClub
{
    public class ClubUpdateValidator : AbstractValidator<ClubUpdateCommand>
    {
        public ClubUpdateValidator()
        {
            RuleFor(c => c.UpdateClubRequest.Name)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
            RuleFor(c => c.UpdateClubRequest.Country)
                .NotEmpty()
                .NotNull()
                .Length(20, 100);
        }
    }
}
