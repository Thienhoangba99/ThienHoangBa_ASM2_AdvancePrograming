using System;

namespace thienApp_AD_ASM_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;
            while (n == 1)
            {
                Console.WriteLine("Vui long chon action you want to do" +
                    "\n1: Calculate the circumference and area square" +
                    "\n2: Calculate the circumference and area rectangle" +
                    "\n3: End program");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("Please enter one side length square ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        hinhvuong hv = new hinhvuong(a);
                        Console.WriteLine("Area square la: " + hv.tinhdientich(a) + "\nchu vi square la: " + hv.tinhchuvi(a));
                        n = 1;
                        break;
                    case 2:
                        Console.WriteLine("Please enter chieu height va width cua rectangle ");
                        Console.Write("length is: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("width is: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        hinhchunhat hcn = new hinhchunhat(b, c);
                       Console.WriteLine("Area rectangle la: " + hcn.tinhdientich(b,c) + "\nchu vi rectangle la: " + hcn.tinhchuvi(b,c));
                        n = 1;
                        break;
                    default:
                        Console.WriteLine("thank you for use program, see u again");
                        n = 2;
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
