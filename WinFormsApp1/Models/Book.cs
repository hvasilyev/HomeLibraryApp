using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public class Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Author { get; set; }
        public Genre Genre { get; set; } 
        public int Year { get; set; } 
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Language Language { get; set; } = Language.English;
        public double Rating { get; set; } = 0.0;
        public BookStatus Status { get; set; } = BookStatus.None;
        public string Note { get; set; } = "";


        public override string ToString()
        {
            return $"{Id}|{Title}|{Author}|{Genre}|{Year}|{Description}|{ImagePath}|{Language}|{Rating}|{Status}|{Note}";
        }
        public static Book FromString(string line)
        {
            var parts = line.Split("|");
            return new Book
            {
                Id = Guid.Parse(parts[0]),
                Title = parts[1],
                Author = parts[2],
                Genre = Enum.TryParse(parts[3], out Genre genre) ? genre : Genre.Fiction,
                Year = int.Parse(parts[4]),
                Description = parts[5],
                ImagePath = parts.Length > 6 ? parts[6] : "",
                Language = parts.Length > 7 && Enum.TryParse(parts[7], out Language lang) ? lang : Language.English,
                Rating = parts.Length > 8 ? double.TryParse(parts[8], out var rating) ? rating : 0.0 : 0.0,
                Status = parts.Length > 9 && Enum.TryParse(parts[9], out BookStatus status) ? status : BookStatus.None,
                Note = parts.Length > 10 ? parts[10] : ""
            };
        }
    }
}
