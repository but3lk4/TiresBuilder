namespace Wulkanizacja
{
    partial class Program
    {
        abstract class TireBuilder
        {
            protected Tire tire;

            public Tire Tire
            {
                get { return tire; }
            }

            public abstract void BuildId();
            public abstract void BuildMaker();
            public abstract void BuildModel();
            public abstract void BuildSize();
            public abstract void BuildPrice();

        }
    }

}
