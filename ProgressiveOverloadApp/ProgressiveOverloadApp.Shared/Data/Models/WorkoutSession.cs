namespace ProgressiveOverloadApp.Shared.Data.Models;

public class WorkoutSession {
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public List<Workout> Workouts { get; set; }
}