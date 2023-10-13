using System;
using System.ComponentModel.DataAnnotations;

namespace MvcRug.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}