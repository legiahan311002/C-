using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_OOP
{
    public class Phanso
    {
        private int tuso;
        private int mauso;

        public Phanso()
        {
            tuso = 0;
            mauso = 1;
        }

        public Phanso(int ts, int ms)
        {
            tuso = ts;
            mauso = ms;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Nhap mau so: ");
                mauso = int.Parse(Console.ReadLine());
            } while (mauso == 0);
        }

        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", tuso, mauso);
        }

        public Phanso Cong(Phanso ps)
        {
            int ts = tuso * ps.mauso + mauso * ps.tuso;
            int ms = mauso * ps.mauso;
            Phanso kq = new Phanso(ts, ms);
            return kq;
        }

        public Phanso Tru(Phanso ps)
        {
            int ts = tuso * ps.mauso - mauso * ps.tuso;
            int ms = mauso * ps.mauso;
            Phanso kq = new Phanso(ts, ms);
            return kq;
        }

        public Phanso Nhan(Phanso ps)
        {
            int ts = tuso * ps.tuso;
            int ms = mauso * ps.mauso;
            Phanso kq = new Phanso(ts, ms);
            return kq;
        }

        public Phanso Chia(Phanso ps)
        {
            int ts = tuso * ps.mauso;
            int ms = mauso * ps.tuso;
            Phanso kq = new Phanso(ts, ms);
            return kq;
        }
    }
}
