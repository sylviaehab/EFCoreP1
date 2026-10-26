using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreP1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int Price { get; set; }
        public  int PageNumber { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }
    }
}
