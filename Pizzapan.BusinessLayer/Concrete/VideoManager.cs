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
    public class VideoManager : IVideoService
    {
        private readonly IVideoDal _videoDal;

        public VideoManager(IVideoDal videoDal)
        {
            _videoDal = videoDal;
        }

        public void TDelete(Video t)
        {
            _videoDal.Delete(t);
        }

        public Video TGetById(int id)
        {
            return _videoDal.GetById(id);
        }

        public List<Video> TGetList()
        {
            return _videoDal.GetList();
        }
        public void TInsert(Video t)
        {
            _videoDal.Insert(t);
        }

        public void TUpdate(Video t)
        {
            _videoDal.Update(t);
        }
    }
}
