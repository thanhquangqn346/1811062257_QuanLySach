using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1811062257_QuanLySach.Models
{
    public class Sach
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }

    }
}