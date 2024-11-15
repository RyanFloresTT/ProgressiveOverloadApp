using ProgressiveOverloadApp.Shared.Data.Models;

namespace ProgressiveOverloadApp.Shared.Services;
public interface IWorkoutService {
    public List<Workout> GetWorkouts();
    public void AddWorkout(Workout workout);
    public void DeleteWorkout(Workout workout);
}
