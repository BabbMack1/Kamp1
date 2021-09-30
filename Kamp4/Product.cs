using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamp4
{
    public class Product  //Başına publici biz ekledik.Ulaşılabilir olması için.
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyat { get; set; }
        public string aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
