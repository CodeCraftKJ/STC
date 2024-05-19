
namespace STC.Storage.Repository
{
    internal interface IMovieRepository
    {
        List<Entities.Movie> GetMovies();
        Entities.Movie GetMovie(long movieId);
        void AddMovie(Entities.Movie movie);
        void EditMovie(Entities.Movie movie);
        void RemoveMovie(long id);
        bool IsMovieExist(long movieId);
        bool IsMovieExist(string name,int year);
        bool IsSeanceExist(DateTime date);
        void AddSeance(Entities.Seance seance);
        void BuyTicket(Entities.Ticket ticket);
        List<Entities.Seance> GetSeancesByMovieId(long movieId);
        Entities.Movie GetSeanceDetails(long movieId);
    }
}
