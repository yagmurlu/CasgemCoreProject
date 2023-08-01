using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class FooterManager : IFooterService
    {
        private readonly IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void TDelete(Footer t)
        {
            _footerDal.Delete(t);
        }

        public Footer TGetById(int id)
        {
            return _footerDal.GetById(id);
        }

        public List<Footer> TGetList()
        {
            return _footerDal.GetList();
        }

        public void TInsert(Footer t)
        {
            _footerDal.Insert(t);
        }

        public void TUpdate(Footer t)
        {
            _footerDal.Update(t);
        }
    }
}
