using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.EX;

public class HomePage
{


    public void setGoal(PlanFactory factory)
    {

        var mealPlan = factory.createMealPlan();
        var workoutPlan = factory.createWorkoutPlan();
        Console.WriteLine(workoutPlan);
        Console.WriteLine(mealPlan);
    }
}
