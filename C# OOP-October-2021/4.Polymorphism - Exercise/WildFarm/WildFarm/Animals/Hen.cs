﻿using System;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight,  double wingSize)
            : base(name, weight,  wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }

        public override void Eat(IFood food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }
    }
}
