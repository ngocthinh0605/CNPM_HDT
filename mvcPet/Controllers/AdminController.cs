
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mvcPet.Models;

namespace mvcPet.Controllers
{
    
    
    public class AdminController: Controller
    {
        
        private readonly IAdminService adService;
        private readonly IWebHostEnvironment webHostEnvironment; 
        
        private readonly PetContext petContext;

        public AdminController(IAdminService adService,IWebHostEnvironment webHostEnvironment,PetContext petContext)
        {
            this.adService=adService;
            this.webHostEnvironment=webHostEnvironment;
            this.petContext=petContext;
        }

        [Route ("/admin", Name = "admin")]
        public ActionResult Index()
        {
            var vm = new AdminViewModel()
            {
                TotalLoai = adService.TotalLoai(),
                Totalsp = adService.Totalsp(),
                TotalKH = adService.TotalKH(),
                HDdanggiao =adService.HDdanggiao(),
                HDdagiao =adService.HDdagiao(),
                HDdahuy= adService.HDdahuy(),
                TotalDT=adService.TotalDT()
            };
            return PartialView("~/Views/Shared/_Admin.cshtml",vm);   
        }
        [Route ("/quan-ly-loai-sp", Name = "quan-ly-loai-sp")]
        public ActionResult QLLOAI()
        {
            var vm = new AdminViewModel()
            {
                GetLoai=adService.GetLoai()
            };
            return PartialView("~/Views/Shared/LoaiSP/_LoaiSP.cshtml",vm);   
        }
        public IActionResult Create()
        {
            return PartialView("~/Views/Shared/LoaiSP/Create.cshtml");
        }

        [HttpPost]  
        public IActionResult Create(LoaiThuCungAdminDTO loai)
        {
                string uniqueFileName = UploadedFile(loai);
                LoaiThuCung loaiThu = new LoaiThuCung()
                {
                    TenLoai=loai.TenLoai,
                    SoLuong= loai.SoLuong,
                    TapTinh=loai.TapTinh,
                    NgoaiHinh=loai.NgoaiHinh,
                    CachNuoi=loai.CachNuoi,
                    TuoiTho=loai.TuoiTho,
                    Description=loai.TapTinh,
                    Image=uniqueFileName
                };
                petContext.loaiThuCungs.Add(loaiThu);
                petContext.SaveChanges();
                return RedirectToAction("QLLOAI");
        }

        private string UploadedFile(LoaiThuCungAdminDTO loai)
        {
            string uniqueFileName = "117837506_988662431545637_4037446169614501248_o.jpg";  
  
            if (loai.Image != null)  
            {  
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");  
                uniqueFileName = Guid.NewGuid().ToString() + "_" + loai.Image.FileName;  
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    loai.Image.CopyTo(fileStream);  
                }  
            }  
            return uniqueFileName; 
            
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            var loai = adService.GetBy(id);
            return PartialView("~/Views/Shared/LoaiSP/Edit.cshtml",loai);
        }

        [HttpPost]
        public IActionResult Edit(int id,LoaiThuCungDTO loai)
        {
            
                var loaithuCung= petContext.loaiThuCungs.FirstOrDefault(m => m.IdLoaiThuCung==id);
                    loaithuCung.TenLoai=loai.TenLoai;
                    loaithuCung.SoLuong= loai.SoLuong;
                    loaithuCung.TapTinh=loai.TapTinh;
                    loaithuCung.NgoaiHinh=loai.NgoaiHinh;
                    loaithuCung.CachNuoi=loai.CachNuoi;
                    loaithuCung.TuoiTho=loai.TuoiTho;
                    loaithuCung.Description=loai.TapTinh;
                    petContext.SaveChanges();
                return RedirectToAction("QLLOAI");
        }
        public IActionResult Delete(int id)
        {
           adService.Delete(id);
           
            return RedirectToAction("QLLOAI");
        }

        public IActionResult IndexSanPham()
        {
            var vm = new AdminViewModel()
            {
                GetThuCung= adService.GetThuCung()
            };
            return PartialView("~/Views/Shared/SanPham/Index.cshtml",vm);
        }

         public IActionResult HoaDonDagGiao()
        {
            var vm = new AdminViewModel()
            {
                GetHoaDonDangGiao= adService.GetHoaDonDangGiao()
            };   
            return PartialView("~/Views/Shared/HoaDon/HoaDondanggiao.cshtml",vm);
        }
         public IActionResult HoaDonDaGiao()
        {
            var vm = new AdminViewModel()
            {
                GetHoaDonDaGiao= adService.GetHoaDonDaGiao()
            };   
            return PartialView("~/Views/Shared/HoaDon/HoDondagiao.cshtml",vm);
        }
         public IActionResult HoaDonDaHuy()
        {
            var vm = new AdminViewModel()
            {
                GetHoaDonHuy=adService.GetHoaDonHuy()
            };   
            return PartialView("~/Views/Shared/HoaDon/HoaDonHuy.cshtml",vm);
        }
         public IActionResult ViewBills(int idhoadon)
        {
            var vm = new AdminViewModel()
            {
                GetChiTietHoaDonDTO= adService.GetChiTietHoaDon(idhoadon),
                GetThuCung=adService.GetThuCung()
            };   

            return PartialView("~/Views/Shared/HoaDon/ViewBills.cshtml",vm);
        }

        public IActionResult HideSanPham(int id)
        {
            adService.HideSP(id);
            return RedirectToAction("IndexSanPham");
        }
        public IActionResult ShowSanPham(int id)
        {
            adService.ShowSP(id);
            return RedirectToAction("IndexSanPham");
        }
        public IActionResult HideKH(string id)
        {
            adService.HideKH(id);
            return RedirectToAction("QLTK");
        }
        public IActionResult ShowKH(string id)
        {
            adService.ShowKH(id);
            return RedirectToAction("QLTK");
        }
         public IActionResult HideNV(string id)
        {
            adService.HideNV(id);
            return RedirectToAction("QLNV");
        }
        public IActionResult ShowNV(string id)
        {
            adService.ShowNV(id);
            return RedirectToAction("QLNV");
        }
        [HttpGet]
        public IActionResult CreateSP()
        {
            List<LoaiThuCung> loaisp = new  List<LoaiThuCung>();
            loaisp= petContext.loaiThuCungs.ToList();
            loaisp.Insert(0, new LoaiThuCung{IdLoaiThuCung=0, TenLoai="Select"});
            ViewBag.List= loaisp;
            return PartialView("~/Views/Shared/SanPham/Create.cshtml");
        }

         [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult CreateSP(ThuCungDTO model)  
        {  
              
                string uniqueFileName = UploadedFile(model);  
              
                ThuCung employee = new ThuCung  
                {  
                    TenThuCung=model.TenThuCung,
                    NgaySinh=model.NgaySinh,
                    CanNang=model.CanNang,
                    GiaBan=model.GiaBan,
                    MauLong="trắng",
                    GiaNhap=model.GiaNhap,
                    Image = uniqueFileName,
                    IdLoaiThuCung=model.IdLoaiThuCung,
                    IsFeatured=true
                };  
                petContext.thuCungs.Add(employee);  
                petContext.SaveChanges();  
                return RedirectToAction("IndexSanPham");  
           
        }  
  
        public IActionResult EditSP(int id)
        {
            List<LoaiThuCung> loaisp = new  List<LoaiThuCung>();
            loaisp= petContext.loaiThuCungs.ToList();
            loaisp.Insert(0, new LoaiThuCung{IdLoaiThuCung=0, TenLoai="Select"});
            ViewBag.List= loaisp;
            var thuCung= adService.GetByTC(id);
            return PartialView("~/Views/Shared/SanPham/Edit.cshtml",thuCung);
        }

         [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult EditSP(int id,ThuCungDTO model)  
        {  
              
                var thuCung= petContext.thuCungs.FirstOrDefault(m => m.IdThuCung==id);
                thuCung.TenThuCung=model.TenThuCung;
                thuCung.NgaySinh=model.NgaySinh;
                thuCung.GiaNhap=model.GiaNhap;
                thuCung.GiaBan=model.GiaBan;
                thuCung.IdLoaiThuCung=model.IdLoaiThuCung;
                thuCung.CanNang=model.CanNang;
                petContext.SaveChanges();
                return RedirectToAction("IndexSanPham");  
           
        }  
  
        private string UploadedFile(ThuCungDTO model)  
        {  
            string uniqueFileName = "117837506_988662431545637_4037446169614501248_o.jpg";  
  
            if (model.ProfileImage != null)  
            {  
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");  
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;  
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    model.ProfileImage.CopyTo(fileStream);  
                }  
            }  
            return uniqueFileName;  
        } 

        [Authorize(Roles ="Admin")]
        public IActionResult QLTK()
        {
            var vm = new AdminViewModel()
            {
                GetKhachHangDTO= adService.GetNhanVien()
            };
            return PartialView("~/Views/Shared/TaiKhoan/Index.cshtml",vm);
        }
         [Authorize(Roles ="Admin")]
         public IActionResult QLNV()
        {
            var vm = new AdminViewModel()
            {
                GetNhanVienDTO= adService.GetNhanVienn()
            };
            return PartialView("~/Views/Shared/NhanVien/Index.cshtml",vm);
        }

        [HttpGet]
        public IActionResult CreateKH()
        {
            return PartialView("~/Views/Shared/TaiKhoan/Create.cshtml");
        }

         [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult CreateKH(KhachHangDTO model)  
        {  
             
            adService.AddKH(model);    
            return RedirectToAction("QLTK");  
          
        } 
        [HttpGet]
        public IActionResult CreateNV()
        {
            List<Role> loaisp = new  List<Role>();
            loaisp= petContext.Role.ToList();
            loaisp.Insert(0, new Role{IdRole=0, TenRole="Select"});
            ViewBag.List= loaisp;
            return PartialView("~/Views/Shared/NhanVien/Create.cshtml");
        }

         [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult CreateNV(NhanVienDTO model)  
        {  
             
            adService.AddNV (model);    
            return RedirectToAction("QLNV");  
          
        }  

        public IActionResult EditKH(string id)
        {
            var thuCung= adService.GetByKH(id);
            return PartialView("~/Views/Shared/TaiKhoan/Edit.cshtml",thuCung);
        }

         [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult EditKH(string id,KhachHangDTO model)  
        {  
              
                var thuCung= petContext.KhachHangs.FirstOrDefault(m =>m.UserName==id);
                thuCung.TenUser=model.TenUser;
                thuCung.MatKhau=model.MatKhau;
                thuCung.SoDienThoai=model.SoDienThoai;
                thuCung.DiaChi=model.DiaChi;
                thuCung.GioiTinh=model.GioiTinh;
                thuCung.Email=model.Email;
                petContext.SaveChanges();
                return RedirectToAction("IndexSanPham");  
           
        }  
         public IActionResult EditNV(string id)
        {
            var thuCung= adService.GetByNV(id);
            return PartialView("~/Views/Shared/NhanVien/Edit.cshtml",thuCung);
        }

        [HttpPost]  
        [ValidateAntiForgeryToken]  
        public IActionResult EditNV(string id,NhanVienDTO model)  
        {  
              
                var thuCung= petContext.NhanViens.FirstOrDefault(m =>m.UserName==id);
                thuCung.TenUser=model.TenUser;
                thuCung.MatKhau=model.MatKhau;
                thuCung.SoDienThoai=model.SoDienThoai;
                thuCung.DiaChi=model.DiaChi;
                thuCung.GioiTinh=model.GioiTinh;
                thuCung.Email=model.Email;
                petContext.SaveChanges();
                return RedirectToAction("QLNV");  
           
        }  

        public IActionResult ViewThongKe()
        {
            var vm = new AdminViewModel()
            {
                TotalDT=adService.TotalDT(),
                TotalChi=Convert.ToDecimal(adService.TotalChi()),
                
                GetHoaDonDaGiao= adService.Filter(),
                Total=Convert.ToDecimal(adService.TotalDT())-Convert.ToDecimal(adService.TotalChi())

            };
            return PartialView("~/Views/Shared/ThongKe/Index.cshtml",vm);
        }

        public IActionResult Login(string user,string pass)
        {
            if (!string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass))
            {
                return RedirectToAction("Index");
            }
            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            var check = petContext.NhanViens.FirstOrDefault(m => m.UserName==user && m.MatKhau==pass && m.IdRole1==2);
            if (user=="thang" && pass=="12345"||user=="ngan" && pass=="12345")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,user),
                    new Claim(ClaimTypes.Role,"Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            var check1 = petContext.NhanViens.FirstOrDefault(m => m.UserName==user && m.MatKhau==pass && m.IdRole1==1);

            if (user=="hoa" && pass=="12345"||user=="thom" && pass=="12345"||user=="thuan" && pass=="12345")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name,user),
                    new Claim(ClaimTypes.Role,"User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);
                isAuthenticate = true;
            }
            if (isAuthenticate)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index");
            }
             return PartialView("~/Views/Shared/Login/Login.cshtml");
        }
       
    }
}