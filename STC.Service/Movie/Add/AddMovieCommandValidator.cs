using FluentValidation;

namespace STC.Service.Movie.Add
{
    internal class AddMovieCommandValidator : AbstractValidator<AddMovieCommand>
    {
        public AddMovieCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1900, 2080);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);
        }
    }
}
