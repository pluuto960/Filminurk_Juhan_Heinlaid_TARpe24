using Filminurk.Core.Domain;

namespace Filminurk.Models.Movies
{
    public class MoviesIndexViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime FirstPublished { get; set; }
       
        public decimal? CurrentRating { get; set; }
        //public List<UserComment>? Reviews { get; set; }

        /*3 õpilase valitud andmetyypi*/
        public Genre? MovieGenre { get; set; }
        public string? MovieInspiration { get; set; }
    }
}
