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
                    "\n1: tinh chu vi va dien tich hinh vuong" +
                    "\n2: tinh chu vi va dien tich hinh chu nhat" +
                    "\n3: ket thuc chuong trinh");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.Write("vui long nhap vao chieu dai canh cua hinh vuong ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        hinhvuong hv = new hinhvuong(a, a);
                        Console.WriteLine("dien tich hinh vuong la: " + hv.tinhdientich() + "\nchu vi hinh vuong la: " + hv.tinhchuvi());
                        n = 1;
                        break;
                    case 2:
                        Console.WriteLine("vui long nhap vao chieu height va weight cua hinh chu nhat ");
                        Console.Write("height la: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("weight la: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        hinhchunhat hcn = new hinhchunhat(b, c);
                        Console.WriteLine("dien tich hinh chu nhat la: " + hcn.tinhdientich() + "\nchu vi hinh chu nhat la: " + hcn.tinhchuvi());
                        n = 1;
                        break;
                    default:
                        Console.WriteLine("cam on ban da su dung chuong trinh, hen gap lai ban trong thoi gian som nhat");
                        n = 2;
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
