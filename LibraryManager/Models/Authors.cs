using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
    }

}
