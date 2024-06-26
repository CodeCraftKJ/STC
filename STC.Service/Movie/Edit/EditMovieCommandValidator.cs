﻿using FluentValidation;

namespace STC.Service.Movie.Edit
{
    internal class EditMovieCommandValidator : AbstractValidator<EditMovieCommand>
    {
        public EditMovieCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Year).InclusiveBetween(1900, 2040);
            RuleFor(x => x.SeanceTime).InclusiveBetween(30, 300);
            RuleFor(x => x.Description).NotEmpty();
        }
    }
}
