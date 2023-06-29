using APIGym.Data;
using APIGym.Entities;

namespace APIGym.Repositories.WorkoutRepositories
{
    public class WorkoutRepository : IWorkoutRepository
    {
        private WorkoutContext _context;
        public WorkoutRepository(WorkoutContext context)
        {
            _context = context;
        }

        public IEnumerable<Workout> GetAll()
        {
            return _context.Workouts;
        }
    }
}
