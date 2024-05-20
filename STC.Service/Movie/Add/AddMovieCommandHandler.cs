using STC.Service.Command;

namespace STC.Service.Movie.Add
{
    public sealed class AddMovieCommandHandler : ICommandHandler<AddMovieCommand>
    {
        private readonly IMovieRepository _repository;

        public AddMovieCommandHandler(IMovieRepository repository)
        {
            _repository = repository;
        }

        public Result Handle(AddMovieCommand command)
        {
            var validationResult = new AddMovieCommandValidator().Validate(command);
            if (!validationResult.IsValid)
            {
                return Result.Fail(validationResult);
            }

            var isExist = _repository.IsMovieExist(command.Name, command.Year);
            if (isExist)
            {
                return Result.Fail("This Movie already exists");
            }

            var movie = new Storage.Entities.Movie(command.Name, command.Year, command.SeanceTime, command.Description, command.CategoryId);
            _repository.AddMovie(movie);

            return Result.OK();
        }
    }
}
