using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yazar
    {
        [Key]
        public int YazarID { get; set; }
        public string YazarAdi { get; set; }
        public string YazarEposta { get; set; }
        public string YazarSifre { get; set; }
        public string YazarHakkinda { get; set; }
        public string YazarResim { get; set; }
        public string YazarDurum { get; set; }
    }
}
