using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballApp.Models
{
    public class Problem
    {
        //[Required]
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        //[Required]
        public string Title { get; set; }
        //public DateTime Date { get; set; }
        public string? Description { get; set; }
        public string? PossibleSolution { get; set; }
        //public string Image { get; set; }
        //public bool IsSolved { get; set; }
    }
}
