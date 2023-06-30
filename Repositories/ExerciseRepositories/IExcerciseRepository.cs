using APIGym.Entities;

namespace APIGym.Repositories.ExerciseRepositories
{
    public interface IExcerciseRepository
    {
        public Exercise returnExcercise(int Id);
    }
}
