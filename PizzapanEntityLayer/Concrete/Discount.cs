
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountUseNumber { get; set; } //Kupon kullanım sayısı
        public DateTime DiscountFirstCodeDate { get; set; }//Kupon oluşturma tarihi
        public DateTime DiscountDeadlineCodeDate { get; set; }//Kupon son kullanma tarihi
    }
}
