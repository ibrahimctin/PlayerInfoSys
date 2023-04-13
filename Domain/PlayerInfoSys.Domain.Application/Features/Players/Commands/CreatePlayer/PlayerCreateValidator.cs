namespace PlayerInfoSys.Domain.Application.Features.Players.Commands.CreatePlayer
{
    public class PlayerCreateValidator : AbstractValidator<PlayerCreateCommand>
    {
        public PlayerCreateValidator()
        {
            RuleFor(p => p.CreatePlayerRequest.ClubId)
                .NotEmpty()
                .NotNull();
            RuleFor(p => p.CreatePlayerRequest.PlaceOfBirth)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.CreatePlayerRequest.Citizenship)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.CreatePlayerRequest.Name)
                .NotEmpty()
                .NotNull()
                .Length(10, 50);
            RuleFor(p => p.CreatePlayerRequest.Outfitter)
                .NotEmpty()
                .NotNull()
                .Length(2, 50);
            RuleFor(p => p.CreatePlayerRequest.PlayerAgent)
                .NotEmpty()
                .NotNull()
                .Length(2, 50);
            RuleFor(p => p.CreatePlayerRequest.Rumours)
                .NotEmpty()
                .NotNull()
                .Length(2, 100);
            RuleFor(p => p.CreatePlayerRequest.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .LessThan(p => DateTime.Now);
        }
    }
}
