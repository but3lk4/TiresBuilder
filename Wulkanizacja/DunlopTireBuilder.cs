namespace Wulkanizacja
{
    partial class Program
    {
        public partial class MainApp
        {
            class DunlopTireBuilder : TireBuilder
            {

                public DunlopTireBuilder()
                {
                    tire = new Tire("Opona Zimowa");

                }

                public override void BuildId()
                {
                    tire["ID"] = "123789";
                }

                public override void BuildMaker()
                {
                    tire["Maker"] = "Dunlop";
                }

                public override void BuildModel()
                {
                    tire["Model"] = "Winter Sport 5";
                }

                public override void BuildSize()
                {
                    tire["Size"] = "195/55 R16";
                }

                public override void BuildPrice()
                {
                    tire["Price"] = "380";
                }
            }
        }
    }

}
