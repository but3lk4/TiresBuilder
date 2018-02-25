using System;

namespace Wulkanizacja
{
    partial class Program
    {
         class CustomersBase
        {
            private DataObject _dataObject;
            protected string group;

            public CustomersBase(string group)
            {
                this.group = group;
            }

            public DataObject Data
            {
                set { _dataObject = value; }
                get { return _dataObject; }
            }

            public virtual void Add(string customer)
            {
                _dataObject.AddRecord(customer);
            }

            public virtual void Delete(string customer)
            {
                _dataObject.DeleteRecord(customer);
            }

            public virtual void Show()
            {
                Console.WriteLine("Lista Klientów: " +group);
                _dataObject.ShowAllRecord();
            }
        }


    }

}
