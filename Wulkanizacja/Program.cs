using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Wulkanizacja
{
    partial class Program
    {
        public partial class MainApp
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Dostępne komendy: Lista Opon[o], Lista Klientów[k], Zapisz[s], Wczytaj[l], Wyjście [q]");
                string command;
                Boolean quitNow = false;
                while (!quitNow)

                {
                    command = Console.ReadLine();
                    switch (command)
                    {
                        case "o":
                            TireBuilder builder;

                            var shop = new Shop();

                            builder = new PirelliTireBuilder();
                            shop.Construct(builder);
                            builder.Tire.Show();

                            builder = new MichelinTireBuilder();
                            shop.Construct(builder);
                            builder.Tire.Show();

                            builder = new YokohamaTireBuilder();
                            shop.Construct(builder);
                            builder.Tire.Show();

                            builder = new DunlopTireBuilder();
                            shop.Construct(builder);
                            builder.Tire.Show();
                            break;

                        case "k":
                            Customers customers = new Customers("Sportowcy");

                            customers.Data = new CustomersData();

                            customers.Show();
                            customers.Delete("Robert Kubica");
                            

                           
                            break;
                        case "a":
                            Customers customersAdd = new Customers("Sportowcy");
                            customersAdd.Data = new CustomersData();
                            customersAdd.Add("Fernando Alonso");


                            break;
                        case "d":
                            Customers customersDel = new Customers("Sportowcy");

                            customersDel.Data = new CustomersData();

                            customersDel.Delete("Robert Kubica");

                            break;



                       case "s":
                         

                          break;

                        case "l":

                            using (StreamReader readtext = new StreamReader("wulkanizacja.txt"))
                            {
                                string readMeText = readtext.ReadLine();
                            }

                            break;

                        case "q":

                            Environment.Exit(0);

                            break;
                        default:
                            Console.WriteLine("nieznana komenda" + command);
                            break;
                    }


                }



            }
        }
    }

}
