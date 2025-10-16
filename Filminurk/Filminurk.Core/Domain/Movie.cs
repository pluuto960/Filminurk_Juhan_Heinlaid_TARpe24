using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Filminurk.Core.Domain
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string>? Actors { get; set; }

    }
}
