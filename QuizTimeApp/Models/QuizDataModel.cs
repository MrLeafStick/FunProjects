using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizTimeApp.Models
{
    public class QuizDataModel
    {
        public int QuizId { get; set; }
        public string Title { get; set; }

        public string Category { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }
    }
}
