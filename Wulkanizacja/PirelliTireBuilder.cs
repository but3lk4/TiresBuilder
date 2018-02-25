namespace Wulkanizacja
{
    partial class Program
    {
        class PirelliTireBuilder : TireBuilder
        {
            public PirelliTireBuilder()
            {
                tire = new Tire("Opona Letnia");

            }

            public override void BuildId()
            {
                tire["ID"] = "123456";
            }

            public override void BuildMaker()
            {
                tire["Maker"] = "Pirelli";
            }

            public override void BuildModel()
            {
                tire["Model"] = "P7 Cinturato";
            }

            public override void BuildSize()
            {
                tire["Size"] = "205/55 R16";
            }

            public override void BuildPrice()
            {
                tire["Price"] = "420";
            }

        }
    }

}
