using APIGym.Entities;

namespace APIGym.Repositories.ExerciseRepositories
{
    public interface IExcerciseRepository
    {
        public IEnumerable<Exercise> ReturnExcercises(int Id);
    }
}
