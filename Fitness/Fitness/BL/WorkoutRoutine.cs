using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class WorkoutRoutine
    {
        private string Name;
        private string Description;
        private List<Exercise> 
            ExerciseList;
        public WorkoutRoutine(string name, string description)
        {
            this.Name = name;
            this.Description = description;
            ExerciseList = new List<Exercise>();
        }
        public void setName(string name) 
        {
            this.Name = name;
        }
        public string getName() { return this.Name; }

        public string getDescription() { return this.Description;}

        public void setDescription(string description) { this.Description = description;}

        public List<Exercise> getExerciseList() {  return this.ExerciseList;}
        public void addExercise(string content)
        {
            this.ExerciseList.Add(new Exercise(content));
        }
        public void removeExercise(string content)
        {
            for (int i = 0;i< ExerciseList.Count; i++)
            {
                if (content == ExerciseList[i].getName())
                {
                    this.ExerciseList.RemoveAt
                        (i);
                }
            }
        }
        public void print()
        {
            Console.WriteLine(Name);
            foreach (Exercise exercise in ExerciseList)
            {
               exercise.print();
            }
        }

    }
}
