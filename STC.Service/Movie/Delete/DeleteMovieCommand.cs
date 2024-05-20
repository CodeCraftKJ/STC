using STC.Service.Command;

namespace STC.Service.Movie.Delete
{
    public sealed class DeleteMovieCommand : ICommand
    {
        public DeleteMovieCommand(long id)
        {
            Id = id;
        }

        public long Id { get; }
    }
}
