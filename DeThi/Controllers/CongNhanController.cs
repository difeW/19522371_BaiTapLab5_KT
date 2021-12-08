using DeThi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeThi.Controllers
{
    public class CongNhanController : Controller
    {
        public IActionResult LietKeCongNhanTheoTrieuChung()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ListByTime(int sotrieuchung)
        {
            DeThiDbContext context = HttpContext.RequestServices.GetService(typeof(DeThi.Models.DeThiDbContext)) as DeThiDbContext;
            return View(context.sqlListByTimeCongNhan(sotrieuchung));
        }

        public IActionResult LietKeCongNhanTheoDiChi()
        {
            DeThiDbContext context = HttpContext.RequestServices.GetService(typeof(DeThi.Models.DeThiDbContext)) as DeThiDbContext;
            return View(context.sqlListDiemCachLy());
        }
        public IActionResult ListTheoDiaChi(string MaDiemCachLy)
        {
            DeThiDbContext context = HttpContext.RequestServices.GetService(typeof(DeThi.Models.DeThiDbContext)) as DeThiDbContext;
            return View(context.sqlListDiemCachLy(MaDiemCachLy));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            DeThiDbContext context = HttpContext.RequestServices.GetService(typeof(DeThi.Models.DeThiDbContext)) as DeThiDbContext;

            return View(context.infoCongNhan(id));
        }
    }
}
