using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Set
    {
        private string Repetition;
        private string Weights;
        public Set(string repetition, string weights)
        {
            this.Repetition = repetition;
            this.Weights = weights;
        }
        public void setRepetition(string name)
        {
            this.Repetition = name;
        }
        public string getRepetition()
        {
            return this.Repetition;
        }
        public string getWeights()
        {
            return this.Weights;
        }
        public void setWeigths(string weigths)
        {
            this.Weights = weigths;
        }
    }
}
