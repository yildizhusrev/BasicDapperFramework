using DapperGenericRepository.DAL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DapperGenericRepository.DAL.Models;

namespace DapperGenericRepository
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Hello World!");
                Console.ReadKey();

                Console.WriteLine("------Select Operation--------");
                KullaniciManager kullaniciManager = new KullaniciManager();
                foreach (DAL.Models.Kullanici VARIABLE in kullaniciManager.GetAll().ToList())
                {
                    Console.WriteLine(VARIABLE.ad);
                }

                Console.ReadKey();
                Console.WriteLine("------Insert Operation--------");
                Kullanici k = new Kullanici()
                {
                    ad = "Kübra",
                    email = "selman@selamn.com",
                    adminMi = false,
                    aktifMi = true,
                    onayKodu = "12586",
                    sifre = "7854123985",
                    soyad = "KAPLAN",
                    telefon = "547856965",
                    universitePersonelMi = false

                };
               var PkId= kullaniciManager.Insert(k);
               k.KullaniciId = Convert.ToInt32(PkId);

               Console.ReadKey();
                Console.WriteLine("------Get By ID Operation--------");
               var user = kullaniciManager.GetById(PkId);
               Console.WriteLine($"ID={user.KullaniciId}\tAD={user.ad}\tSOYAD={user.soyad}");

               Console.ReadKey();
               Console.WriteLine("------Delete Operation--------");
               kullaniciManager.Delete(PkId);


               Console.ReadKey();
               Console.WriteLine("------ Again Select Operation--------");
               kullaniciManager = new KullaniciManager();
               foreach (DAL.Models.Kullanici VARIABLE in kullaniciManager.GetAll().ToList())
               {
                   Console.WriteLine(VARIABLE.ad);
               }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n" + e.InnerException?.Message);
                throw;
            }

            Console.ReadKey();
        }


       

    }
}
