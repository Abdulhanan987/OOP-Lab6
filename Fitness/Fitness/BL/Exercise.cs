using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Exercise
    {
        private string ExerciseName;
        private string ExerciseDescription;
        private string ExerciseType;
        
        private readonly List<Set> sets;
       public Exercise(string name, string description, string type,List<Set> set) 
        {
            this.ExerciseName = name;
            this.ExerciseDescription = description;
            this.ExerciseType = type;
            this.sets = set;
        }

        public Exercise(string content)
        {
            this.ExerciseName = content;
        }

        public void setName(string name)
        {
            this.ExerciseName = name;
        }
        public string getName() { return this.ExerciseName; }

        public void setDescription(string des)
        {
            this.ExerciseDescription = des;
        }
        public void setType(string type)
        { this.ExerciseType = type;}

        public string getType() { return this.ExerciseType;}

        public string getDescription()
        { return this.ExerciseDescription; }
        public List<Set> GetExercises()
        {
            return sets;
        }
        public void print()
        {
            Console.WriteLine(ExerciseName);
        }
    }
}
