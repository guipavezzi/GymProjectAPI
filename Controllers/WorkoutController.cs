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
        public IActionResult RetunWorkout()
        {
            return Ok(_workoutRepository.GetAll());
        }
    }
}