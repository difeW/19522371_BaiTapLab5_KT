using DeThi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeThi.Controllers
{
    public class DiemCachLyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string ThemDCL(DiemCachLyModel diemCachLy)
        {
            int count;
            DeThiDbContext context = HttpContext.RequestServices.GetService(typeof(DeThi.Models.DeThiDbContext)) as DeThiDbContext;
            count = context.sqlInsertDiemCachLy(diemCachLy);
            if (count == 1)
            {
                return "Thêm Thành Công!";
            }
            return "Thêm thất bại";
        }
    }
}
