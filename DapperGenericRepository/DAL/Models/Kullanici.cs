using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperGenericRepository.DAL.Models
{
   public  class Kullanici
    {
        
        [PrimaryKey]
        public int KullaniciId { get; set; }
        public string sifre { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public bool universitePersonelMi { get; set; }
        public bool adminMi { get; set; }
        public bool aktifMi { get; set; }
        public string onayKodu { get; set; }
    }
}
