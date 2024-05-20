using STC.Service.Command;

namespace STC.Service.Movie.Delete
{
    public class DeleteMovieCommand : ICommand
    {
        public DeleteMovieCommand(long id)
        {
            Id = id;
        }
        public long Id { get; }
    }
}
