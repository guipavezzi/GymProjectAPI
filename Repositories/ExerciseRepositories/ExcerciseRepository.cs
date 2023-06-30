using APIGym.Data;
using APIGym.Entities;

namespace APIGym.Repositories.ExerciseRepositories
{
    public class ExcerciseRepository : IExcerciseRepository
    {
        private readonly WorkoutContext _workContext;

        public ExcerciseRepository(WorkoutContext workContext)
        {
            _workContext = workContext;             
        }

        public Exercise returnExcercise(int id)
        {
            return (Exercise)_workContext.Exercises.Select(e => e.Workout.Id == id);
        }
    }
}
