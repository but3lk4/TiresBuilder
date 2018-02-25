using System;
using System.Collections.Generic;

namespace Wulkanizacja
{
    partial class Program
    {
        class CustomersData : DataObject
        {
            private List<string> _customers = new List<string>();
            private string customer;

            public CustomersData()
            {
                _customers.Add("Carlos Sainz");
                _customers.Add("Sebastien Loeb");
                _customers.Add("Robert Kubica");
                _customers.Add("Colin McRae");
            }

            public override void AddRecord(string name)
            {
                _customers.Add(customer);
            }

            public override void DeleteRecord(string name)
            {
                _customers.Remove(customer);
            }

            public override void ShowAllRecord()
            {
                foreach (string customer in _customers)
                {
                    Console.WriteLine(" " + customer);
                }
            }
        }
    }

}
