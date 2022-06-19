using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager
    {
        GenericRepository<Kategori> repo = new GenericRepository<Kategori>();
        public List<Kategori> GetAllBL()
        {
            return repo.Listele();
        }

        public void KategoriAddBL (Kategori p)
        {
            if (p.KategoriAd == "" || p.KategoriAd.Length <= 3 || p.KategoriAciklama == "" || p.KategoriAd.Length >= 51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Ekle(p);
            }
        }
    }
}
