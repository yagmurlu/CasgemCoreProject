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
    public class BestPizzaManager : IBestPizzaService
    {
        private readonly IBestPizzaDal _bestPizzaDal;

        public BestPizzaManager(IBestPizzaDal bestPizzaDal)
        {
            _bestPizzaDal = bestPizzaDal;
        }

        public void TDelete(BestPizza t)
        {
            _bestPizzaDal.Delete(t);
        }

        public BestPizza TGetById(int id)
        {
            return _bestPizzaDal.GetById(id);
        }

        public List<BestPizza> TGetList()
        {
            return _bestPizzaDal.GetList();
        }

        public void TInsert(BestPizza t)
        {
            _bestPizzaDal.Insert(t);
        }

        public void TUpdate(BestPizza t)
        {
            _bestPizzaDal.Update(t);
        }
    }
}
