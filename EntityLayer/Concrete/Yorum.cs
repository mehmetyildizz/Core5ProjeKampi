﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        public string YorumKullaniciAdi { get; set; }
        public string YorumBaslik { get; set; }
        public string YorumIcerik { get; set; }
        public DateTime YorumTarihi { get; set; }
        public bool YorumDurum { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}
