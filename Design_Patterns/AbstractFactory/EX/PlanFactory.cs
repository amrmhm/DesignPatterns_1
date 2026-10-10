using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.AbstractFactory.EX;

public interface PlanFactory
{
     WorkoutPlan  createWorkoutPlan();
     MealPlan createMealPlan();
}
