using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QLNS.Areas.Admin.Forms;
using QLNS.Areas.Admin.Services;
using QLNS.Models;

namespace QLNS.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class NhanVienController : Controller
    {
        private readonly NhanVienService _nhanVienService;
        private readonly CongViecService _congViecService;
        private readonly StatusService _statusService;
        private readonly ViTriService _viTriService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public NhanVienController(NhanVienService nhanVienService, CongViecService congViecService, StatusService statusService, ViTriService viTriService, IWebHostEnvironment webHostEnvironment)
        {
            _nhanVienService = nhanVienService;
            _congViecService = congViecService;
            _statusService = statusService;
            _viTriService = viTriService;
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var nhanViens = await _nhanVienService.GetListNV();
            if (nhanViens != null)
            {
                return View(nhanViens);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ThemNhanVien()
        {
            List<CongViec> congViecs = await _congViecService.GetListCV();
            List<ViTri> viTris = await _viTriService.GetListVT();
            List<StatusNhanVien> statusNVs = await _statusService.GetListStatusNhanVien();
            if (congViecs != null) ViewBag.CongViecs = congViecs;
            if(viTris != null) ViewBag.ViTris = viTris;
            if (statusNVs != null) ViewBag.StatusNV = statusNVs;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ThemNhanVien([FromForm] NhanVienForm? nhanVienForm)
        {
            //gọi lại view để load dữ liệu
            List<CongViec> congViecs = await _congViecService.GetListCV();
            List<ViTri> viTris = await _viTriService.GetListVT();
            List<StatusNhanVien> statusNVs = await _statusService.GetListStatusNhanVien();
            if (congViecs != null) ViewBag.CongViecs = congViecs;
            if (viTris != null) ViewBag.ViTris = viTris;
            if (statusNVs != null) ViewBag.StatusNV = statusNVs;
            try
            {
                if (ModelState.IsValid)
                {
                    // lấy file đường dẫn đến thư mục lưu trữ tệp
                    string webRootPath = _webHostEnvironment.WebRootPath;
                    string pathFolder = Path.Combine(webRootPath, "UpLoadFile"); // Thư mục lưu trữ tệp
                    if (!Directory.Exists(pathFolder))
                    {
                        Directory.CreateDirectory(pathFolder);
                    }
                    // Tạo đường dẫn tệp lưu trữ
                    string fileName = Path.GetFileName(nhanVienForm?.Image?.FileName!);
                    string filePath = Path.Combine(pathFolder, fileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        nhanVienForm?.Image?.CopyTo(fileStream);
                    }
                    await _nhanVienService.ThemNhanVienAsync(nhanVienForm!);
                    ViewBag.Success = "Thêm nhân viên success";
                    return View();
                }
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
        public IActionResult ChiTietNhanVien()
        {
            return View();
        }
        public IActionResult UpdateNhanVien()
        {
            return View();
        }
        public IActionResult DeleteNhanVien()
        {
            return View();
        }
    }
}
