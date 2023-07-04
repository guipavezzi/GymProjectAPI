using APIGym.Repositories.ExerciseRepositories;
using Microsoft.AspNetCore.Mvc;

namespace APIGym.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExcerciseController : ControllerBase
    {
        private readonly IExcerciseRepository _excerciseRepository;
        public ExcerciseController(IExcerciseRepository excerciseRepository)
        {
            _excerciseRepository = excerciseRepository;
        }

        [HttpGet("{id}")]
        public IActionResult getExcercise(int id)
        {
            return Ok(_excerciseRepository.returnExcercises(id));
        }
    }
}
