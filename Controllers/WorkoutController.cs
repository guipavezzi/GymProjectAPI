using APIGym.Repositories.WorkoutRepositories;
using Microsoft.AspNetCore.Mvc;

namespace APIGym.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ControllerBase
    {
        private IWorkoutRepository _workoutRepository;

        public WorkoutController(IWorkoutRepository workoutRepository)
        {
           _workoutRepository = workoutRepository;
        }

        [HttpGet]
        public IActionResult RetunWorkouts()
        {
            return Ok(_workoutRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult RetunWorkout(int id)
        {
            return Ok(_workoutRepository.GetById(id));
        }
    }
}