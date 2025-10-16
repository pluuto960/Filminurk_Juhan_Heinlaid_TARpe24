using Filminurk.Core.Domain;

namespace Filminurk.Models.Movies
{
    public class MoviesIndexViewModel
    {
        public string Title { get; set; }
       

        /*3 õpilase valitud andmetyypi*/
        public Genre? MovieGenre { get; set; }
        public string? MovieInspiration { get; set; }
    }
}
