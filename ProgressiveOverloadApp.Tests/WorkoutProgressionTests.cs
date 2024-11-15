using NUnit.Framework.Legacy;
using ProgressiveOverloadApp.Shared.Data.Models;

namespace ProgressiveOverloadApp.Tests;

[TestFixture]
public class WorkoutProgressionTests {
    [Test]
    public void ShouldIncreaseNextRep_WhenUserCompletesWorkout() {
        // Arrange
        var workout = new Workout {
            TargetWeight = 100,
            Reps = new List<int> { 6, 5, 4, 3 }
        };

        // Act
        workout.Progress();

        Assert.Multiple(() => {
            // Assert
            Assert.That(workout.Reps, Is.EqualTo(new List<int> { 6, 6, 5, 4 }));
            Assert.That(workout.TargetWeight, Is.EqualTo(100));
        });
    }
    [Test]
    public void ShouldIncreaseWeight_WhenUserCompletesFullSet() {
        // Arrange
        var workout = new Workout { 
            Reps = [ 6, 6, 6, 6 ], 
            TargetWeight = 100 
        };

        // Act
        workout.Progress();

        // Assert
        Assert.Multiple(() => {
            Assert.That(workout.TargetWeight, Is.EqualTo(105));
            Assert.That(workout.Reps, Is.EqualTo(new List<int> { 7, 6, 5, 4}));
        });
    }

}
