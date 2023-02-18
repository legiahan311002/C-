using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phanso ps1 = new Phanso();
            Phanso ps2 = new Phanso();
            ps1.Nhap();
            ps2.Nhap();

            Phanso tong = ps1.Cong(ps2);
            Phanso hieu = ps1.Tru(ps2);
            Phanso tich = ps1.Nhan(ps2);
            Phanso thuong = ps1.Chia(ps2);

            Console.WriteLine("Tong 2 phan so: ");
            tong.Xuat();

            Console.WriteLine("Hieu 2 phan so: ");
            hieu.Xuat();

            Console.WriteLine("Tich 2 phan so: ");
            tich.Xuat();

            Console.WriteLine("Thuong 2 phan so: ");
            thuong.Xuat();
        }
    }
}
