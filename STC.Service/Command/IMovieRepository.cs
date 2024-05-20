namespace STC.Service.Command
{
    public interface IMovieRepository
    {
        bool IsMovieExist(string name, int year);
        Storage.Entities.Movie GetMovieById(long id);
        void AddMovie(Storage.Entities.Movie movie);
        void RemoveMovie(long id);
        void EditMovie(Storage.Entities.Movie movie);
    }
}