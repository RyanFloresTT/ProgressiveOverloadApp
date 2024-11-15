namespace ProgressiveOverloadApp.Shared.Data.Models;

public class Workout {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int TargetWeight { get; set; }
    public List<int> Reps { get; set; }
    public int WeightIncrement { get; set; } = 5;
    /// <summary>
    /// String date is DateTime.Now.ToShortDateString()
    /// </summary>
    public List<(string Date, int Weight)> OverloadHistory { get; set; } = new List<(string, int)>();
}

public static class WorkoutExtensions {
    public static void Progress(this Workout workout) {
        int maxReps = workout.Reps[0];
        // check if workout is maxed out at
        if (workout.Reps.All(reps => reps == maxReps)) {
            workout.TargetWeight += workout.WeightIncrement;
            maxReps++;
            workout.Reps = [maxReps, maxReps - 1, maxReps - 2, maxReps - 3];
            workout.OverloadHistory.Add((DateTime.Now.ToShortDateString(), workout.TargetWeight));
        } else {
            // increment sets to the right of the highest
            for (int i = workout.Reps.Count - 1; i > 0; i--) {
                if (workout.Reps[i] < workout.Reps[i - 1]) {
                    workout.Reps[i]++;
                }
            }
        }
    }
}
