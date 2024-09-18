using Microsoft.AspNetCore.Mvc;
using WebBanVali.Repository;
namespace WebBanVali.ViewComponents
{
    public class LoaiSpMenuViewComponent:ViewComponent
    {
        private readonly ILoaiSpRepository _loaiSp;
        public LoaiSpMenuViewComponent(ILoaiSpRepository loaiSpRepository)
        {
            _loaiSp = loaiSpRepository;
        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllSp().OrderBy(x => x.Loai);
            return View(loaisp);
        }
    }
}
