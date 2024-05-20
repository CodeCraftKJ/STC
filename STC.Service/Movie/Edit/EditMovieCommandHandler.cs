using STC.Service.Command;

namespace STC.Service.Movie.Edit
{
    public sealed class EditMovieCommandHandler : ICommandHandler<EditMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public EditMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(EditMovieCommand command)
        {
            var validationResult = new EditMovieCommandValidator().Validate(command);
            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult);
            }
            var movie = _repository.GetMovieById(command.Id);
            if (movie == null)
            {
                return Result.Fail("Movie does not exist.");
            }
            movie.Name = command.Name;
            movie.Year = command.Year;
            movie.TimeMinutes = command.SeanceTime;
            movie.Description = command.Description;

            _repository.EditMovie(movie);
            return Result.OK();
        }
    }
}
