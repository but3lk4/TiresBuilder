namespace Wulkanizacja
{
    partial class Program
    {
        class Shop
        {
            public void Construct(TireBuilder tireBuilder)
            {
                tireBuilder.BuildId();
                tireBuilder.BuildMaker();
                tireBuilder.BuildModel();
                tireBuilder.BuildSize();
                tireBuilder.BuildPrice();
            }
        }
    }

}
