using System;

namespace _5.domaca_zadaca
{
    public interface IIngredient
    {
        void AddIngredient();
    }
    public class Noodles : IIngredient
    {
        public void AddIngredient()
        {
            Console.WriteLine("Add Noodles");
        }
    }
    public class Beef : IIngredient
    {
        public void AddIngredient()
        {
            Console.WriteLine("Add Beef");
        }
    }
    public class Mushrooms : IIngredient
    {
        public void AddIngredient()
        {
            Console.WriteLine("Add Mushrooms");
        }
    }
    public class Water : IIngredient
    {
        public void AddIngredient()
        {
            Console.WriteLine("Add Water");
        }
    }
    public class WaterDecorator : IIngredient
    {
        private readonly IIngredient ingredient;

        public WaterDecorator(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }

        public void AddIngredient()
        {
            Console.WriteLine("Add Water");
            ingredient.AddIngredient();
        }
    }

    public class BeefDecorator : IIngredient
    {
        private readonly IIngredient ingredient;

        public BeefDecorator(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public void AddIngredient()
        {
            Console.WriteLine("Add Beef");
            ingredient.AddIngredient();
        }
    }
    public class MushroomDecorator : IIngredient
    {
        private readonly IIngredient ingredient;

        public MushroomDecorator(IIngredient ingredient)
        {
            this.ingredient = ingredient;
        }
        public void AddIngredient()
        {
            Console.WriteLine("Add Mushrooms");
            ingredient.AddIngredient();
        }
    }
    public static class ClientCode
    {
        public static void Run()
        {
            IIngredient meal = new WaterDecorator(new BeefDecorator(new Noodles()));
            meal.AddIngredient();
        }
    }
}
