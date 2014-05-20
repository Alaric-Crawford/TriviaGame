using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaGame
{
    class Trivia
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public Trivia(string Q, string A)
        {
            this.Question = Q;
            this.Answer = A;
        }
    }
}
