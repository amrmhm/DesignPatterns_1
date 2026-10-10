using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.EX;

public class WeightLossFactory : PlanFactory
{
    public MealPlan createMealPlan()
    {
        return new WeighLossMealPlan();
    }

    public WorkoutPlan createWorkoutPlan()
    {
        return new WeightLossWorkout();

    }
}
   