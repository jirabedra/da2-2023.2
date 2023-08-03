using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain
{
    public class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public string Title { get; set; }
        public IEnumerable<string> Genres { get; set; }
    }
}
