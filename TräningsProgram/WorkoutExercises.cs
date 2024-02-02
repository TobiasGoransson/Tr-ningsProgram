using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TräningsProgram
{
    public class WorkoutExercises
    {
        public string ExerciseName { get; set; }
        public int duration { get; set; }
        public int reps { get; set; }
        public int weight { get; set; }
        public int incline { get; set; }

        public WorkoutExercises(string exerciseName, int duration, int reps, int weight, int incline)
        {
            this.ExerciseName = exerciseName;
            this.duration = duration;
            this.reps = reps;
            this.weight = weight;
            this.incline = incline;
        }
    }
}
