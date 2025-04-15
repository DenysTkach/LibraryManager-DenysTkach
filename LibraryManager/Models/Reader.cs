using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Reader
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Contact { get; set; }
        public DateTime Registered { get; set; }
    }

}
