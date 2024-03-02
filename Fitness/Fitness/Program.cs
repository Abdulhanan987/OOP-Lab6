using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkoutRoutine workoutRoutine = new WorkoutRoutine("Push up","Heavy");
            workoutRoutine.addExercise("This is push up , Heavy");
            Set set = new Set("100","100");
            List<Set> sets = new List<Set>();
            sets.Add(set);
            Exercise exercise = new Exercise("Push up","Hea","Body",sets);
           // workoutRoutine.print();
           // Console.WriteLine(exercise.getDescription());
            workoutRoutine.removeExercise("This is push up , Heavy");
            workoutRoutine.print();
            Console.ReadKey();

        }
    }
}
