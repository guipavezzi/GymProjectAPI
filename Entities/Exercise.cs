namespace APIGym.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        public Workout Workout { get; set; }
        public string Name{ get; set; }
    }
}
