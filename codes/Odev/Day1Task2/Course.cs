using System;
using System.Collections.Generic;
using System.Text;

namespace Day1Task2
{
    public class Course
    {
        public int Id { get; set; }
        public int EducatorId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
