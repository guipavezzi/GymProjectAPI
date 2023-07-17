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

        public IEnumerable<Exercise> ReturnExcercises(int id)
        {
            return _workContext.Exercises.Where(w => w.Workout.Id == id);
        }
    }
}
