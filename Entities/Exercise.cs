using System.Text.Json.Serialization;

namespace APIGym.Entities
{
    public class Exercise
    {
        public int Id { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public Workout Workout { get; set; }
        public string Name{ get; set; }
    }
}
