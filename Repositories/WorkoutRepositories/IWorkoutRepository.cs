using APIGym.Entities;

namespace APIGym.Repositories.WorkoutRepositories
{
    public interface IWorkoutRepository
    {
        public IEnumerable<Workout> GetAll();
    }
}
