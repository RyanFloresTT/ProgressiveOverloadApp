using ProgressiveOverloadApp.Shared.Data.Models;

namespace ProgressiveOverloadApp.Shared.Services;
public class MockWorkoutService : IWorkoutService
{
    readonly List<Workout> _workouts = new();

    public List<Workout> GetWorkouts() => _workouts;

    public void AddWorkout(Workout workout)
    {
        _workouts.Add(workout);
    }

    public void DeleteWorkout(Workout workout)
    {
        _workouts.Remove(workout);
    }
}
