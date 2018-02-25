namespace Wulkanizacja
{
    partial class Program
    {
        class MichelinTireBuilder : TireBuilder
        {
            public MichelinTireBuilder()
            {
                tire = new Tire("Opona Zimowa");

            }

            public override void BuildId()
            {
                tire["ID"] = "654321";
            }

            public override void BuildMaker()
            {
                tire["Maker"] = "Michelin";
            }

            public override void BuildModel()
            {
                tire["Model"] = "Alpin 5";
            }

            public override void BuildSize()
            {
                tire["Size"] = "195/55 R16";
            }

            public override void BuildPrice()
            {
                tire["Price"] = "400zl";
            }

        }
    }

}
