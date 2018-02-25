namespace Wulkanizacja
{
    partial class Program
    {
        class YokohamaTireBuilder : TireBuilder
        {

            public YokohamaTireBuilder()
            {
                tire = new Tire("Opona Letnia");

            }

            public override void BuildId()
            {
                tire["ID"] = "456789";
            }

            public override void BuildMaker()
            {
                tire["Maker"] = "Yokohama";
            }

            public override void BuildModel()
            {
                tire["Model"] = "Advan Sport";
            }

            public override void BuildSize()
            {
                tire["Size"] = "205/50 R17";
            }

            public override void BuildPrice()
            {
                tire["Price"] = "395";
            }
        }
    }
}


