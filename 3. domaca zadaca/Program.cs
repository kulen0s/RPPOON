namespace TehnologijaTrgovina
{
    
    public interface ITvFactory
    {
        ITelevision CreateTelevision();
        IDisplay CreateDisplay();
    }

    public interface ITelevision
    {
        void UseInterface();
    }

    public interface IDisplay
    {
        void UseInterface();
    }

    public class SamsungTelevision : ITelevision
    {
        public void UseInterface() { }
    }


    public class DellTelevision : ITelevision
    {
        public void UseInterface() { }
    }

  
    public class SamsungDisplay : IDisplay
    {
        public void UseInterface() { }
    }

    public class DellDisplay : IDisplay
    {
        public void UseInterface() { }
    }

    public class SamsungFactory : ITvFactory
    {
        public ITelevision CreateTelevision()
        {
            return new SamsungTelevision();
        }

        public IDisplay CreateDisplay()
        {
            return new SamsungDisplay();
        }
    }

    public class DellFactory : ITvFactory
    {
        public ITelevision CreateTelevision()
        {
            return new DellTelevision();
        }

        public IDisplay CreateDisplay()
        {
            return new DellDisplay();
        }
    }

    public class App
    {
        private ITvFactory tvFactory;

        public App(ITvFactory factory)
        {
            tvFactory = factory;
        }

        public void SellTelevision()
        {
            ITelevision tv = tvFactory.CreateTelevision();
        }

        public void SellDisplay()
        {
            IDisplay display = tvFactory.CreateDisplay();
        }
    }
}