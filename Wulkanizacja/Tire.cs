using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace Wulkanizacja
{
    partial class Program
    {
        class Tire
        {
            private string _tireType;
            private Dictionary<string, string> _parts = new Dictionary<string, string>();

            public Tire(string tireType)
            {
                this._tireType = tireType;
            }

            public string this[string key]
            {
                get { return _parts[key]; }
                set { _parts[key] = value; }
            }

            public void Show()
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine("Typ opony: {0}" , _tireType);
                Console.WriteLine("Id opony: {0}" , _parts["ID"]);
                Console.WriteLine("Producent opony: {0}" , _parts["Maker"]);
                Console.WriteLine("Model opony: {0}" , _parts["Model"]);
                Console.WriteLine("Rozmiar opony: {0}" , _parts["Size"]);
                Console.WriteLine("Cena opony: {0}" , _parts["Price"]);

            }

            public void Saver()
            {
                using (StreamWriter file = new StreamWriter("wulkanizacja.txt"))
                    foreach (var entry in _parts)
                        file.WriteLine("[{0} {1}]", entry.Key, entry.Value);
            }
        }
    }

}
