using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF2
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyCoffeeEntities cf = new QuanLyCoffeeEntities();
            /*
            var querry = cf.NhanViens.OrderBy(p => p.TenNV).ToList();
            foreach(var item in querry)
            {
                Console.WriteLine(item.IDNV + " " + item.TenNV);
            }
            */
            /*
            NhanVien nv1 = new NhanVien();
            nv1.IDNV = 1;
            nv1.TenNV = "LeKhai";
            nv1.Gmail = "bakhai@";
            nv1.Sex = "Nam";
            nv1.DiaChi = "HCM";
            nv1.SDT = "00989899";
            cf.NhanViens.Add(nv1);

            cf.SaveChanges();
            */
            
            var querry2 = cf.NhanViens.Where(o => o.IDNV == 1).FirstOrDefault();
            NhanVien nv1 = new NhanVien();
            if(querry2!=null)
            {
                nv1.TenNV = "SGU";
                nv1.DiaChi = "SaiGon";
                nv1.Gmail = "@gmail";
                nv1.SDT = "666666";
            }
            cf.SaveChanges();
            
            /*
            var querry3 = cf.NhanViens.SingleOrDefault(w => w.IDNV == 666);
            if(querry3!=null)
            {

                cf.NhanViens.Remove(querry3);
            }
            cf.SaveChanges();
            */
            Console.ReadLine();
            
        }
    }
}
