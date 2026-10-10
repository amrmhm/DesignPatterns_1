using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.EX;

public class BuildMuscleFactory : PlanFactory
{
    public MealPlan createMealPlan()
    {
        return new BuildMuscleMealPlan();
    }


    public WorkoutPlan createWorkoutPlan()
    {
        return new BuildMuscleWorkout();
    }
}

    