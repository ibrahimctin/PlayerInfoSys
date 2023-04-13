namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.UpdatePlayer
{
    public class PlayerUpdateValidator : AbstractValidator<PlayerUpdateCommand>
    {
        public PlayerUpdateValidator()
        {
            RuleFor(p => p.UpdatePlayerRequest.ClubId)
               .NotEmpty()
               .NotNull();
            RuleFor(p => p.UpdatePlayerRequest.Id)
               .NotEmpty()
               .NotNull();
            RuleFor(p => p.UpdatePlayerRequest.PlaceOfBirth)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.UpdatePlayerRequest.Citizenship)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.UpdatePlayerRequest.Name)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.UpdatePlayerRequest.Outfitter)
                .NotEmpty()
                .NotNull()
                .Length(2, 50);
            RuleFor(p => p.UpdatePlayerRequest.PlayerAgent)
                .NotEmpty()
                .NotNull()
                .Length(2, 50);
            RuleFor(p => p.UpdatePlayerRequest.Rumours)
                .NotEmpty()
                .NotNull()
                .Length(2, 100);
            RuleFor(p => p.UpdatePlayerRequest.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .LessThan(p => DateTime.Now);
        }
    }
}
