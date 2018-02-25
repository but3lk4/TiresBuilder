using System;

namespace Wulkanizacja
{
    partial class Program
    {
        class Customers: CustomersBase
        {
            public Customers(string group)
                :base(group)
            {
                
            }

            public override void Show()
            {
                Console.WriteLine();
                Console.WriteLine("----------------");
                base.Show();
                Console.WriteLine("----------------");
            }
        }
    }

}
