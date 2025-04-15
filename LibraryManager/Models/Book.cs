using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int AuthorId { get; set; }
        public int? ReaderId { get; set; }
        public DateTime? BorrowedDate { get; set; }
    }

}
