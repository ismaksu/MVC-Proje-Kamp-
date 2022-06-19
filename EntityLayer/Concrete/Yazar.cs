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

        [StringLength(50)]
        public string YazarAd { get; set; }

        [StringLength(175)]
        public string YazarResim { get; set; }

        [StringLength(50)]
        public string YazarMail { get; set; }

        [StringLength(50)]
        public string YazarSifre { get; set; }

        //------------------İlişkiler----------------------

        public ICollection<Baslik> Basliks { get; set; }

        public ICollection<Entry> Entries { get; set; }
    }
}
