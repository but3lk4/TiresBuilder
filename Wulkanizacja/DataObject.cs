namespace Wulkanizacja
{
    partial class Program
    {
        abstract class DataObject
        {
            public abstract void DeleteRecord(string name);
            public abstract void AddRecord(string name);
            public abstract void ShowAllRecord();
        }
    }

}
