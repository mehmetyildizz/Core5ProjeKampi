using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Iletisim
    {
        [Key]
        public int IletisimID { get; set; }
        public string IletisimKullaniciAdi { get; set; }
        public string IletisimEposta { get; set; }
        public string IletisimBaslik { get; set; }
        public string IletisimMesaj { get; set; }
        public DateTime IletisimTarihi { get; set; }
        public bool IletisimDurum { get; set; }
    }
}
