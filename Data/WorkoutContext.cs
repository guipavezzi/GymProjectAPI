using APIGym.Entities;
using Microsoft.EntityFrameworkCore;

namespace APIGym.Data
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> opt) : base(opt) 
        {
            
        }

        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
    }
}
