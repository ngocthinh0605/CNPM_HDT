using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcPet.Models;


namespace mvcPet.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;
        private readonly IKhachHangService nguoidungService;
        private readonly ICartService cartService;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ICartService cartService,IHomeService homeService,IKhachHangService nguoidungService)
        {
            _logger = logger;
            this.homeService= homeService;
            this.nguoidungService=nguoidungService;
            this.cartService=cartService;
        }

        // [Route ("/trangchu", Name = "trangchu")]
        public ActionResult Index()
        {
            var ViewIndex= new HomeViewModel()
            {
                banner= homeService.GetAll(),

                GetIndex4Pet= homeService.Get4forIndex(),

                GetBest = homeService.GetBest(),
                
                GetFeatured = homeService.GetFeatured(),

                GetSale =homeService.GetSale(),

                GetThuCungIndex =homeService.GetThuCungIndex(),

                GetAllLoai =homeService.LoaiThuCung(),

                GetThuCung =cartService.GetThuCung(),

                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro"))
            };
            return View(ViewIndex);
        }
       
        public IActionResult Privacy()
        {
            return View();
        }
            
         [HttpGet] 
        public IActionResult Login()  
        {  
            var ViewIndex= new HomeViewModel()
            {
                GetAllLoai =homeService.LoaiThuCung(),

                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),

                GetThuCung=cartService.GetThuCung()
            };
            return View(ViewIndex);
        }  
       
  
        [HttpPost]  
        public IActionResult Login([FromForm] string UserName, [FromForm] string MatKhau)  
        {  
            if(!string.IsNullOrEmpty(UserName) && string.IsNullOrEmpty(MatKhau))  
            {  
                return RedirectToAction("Login");  
            }  
   
            var user = nguoidungService.getKhachHang(UserName,MatKhau);
            if(user.TrangThai==1)
            {
            if (ModelState.IsValid)
            {
                if(user != null){  
                    HttpContext.Session.SetString("VaiTro", user.UserName + "");

                    HttpContext.Session.SetString("TenUser", user.TenUser + "");
                    
                    HttpContext.Session.SetString("Email", user.Email + "");

                    HttpContext.Session.SetString("SDT", user.SoDienThoai + "");

                    HttpContext.Session.SetString("DiaChi", user.DiaChi + "");
 
                    var identity = new ClaimsIdentity(new[] {  
                        new Claim(ClaimTypes.Name, UserName)  
                    }, CookieAuthenticationDefaults.AuthenticationScheme);  
    
                    var principal = new ClaimsPrincipal(identity);  
    
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);  
    
                    ViewBag.Sucess="Đăng nhập thành công";

                    ViewBag.UserName=user.TenUser;

                    return  RedirectToAction("Index", "Home");
                }  
                else{
                    ViewBag.Fail="Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            else
            {
                 ViewBag.Lock="Tài khoản của bạn đã bị khóa";
                 return RedirectToAction("Login");
            }
            }
            var ViewIndex= new HomeViewModel()
            {
                GetAllLoai =homeService.LoaiThuCung(),
                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),
                GetThuCung=cartService.GetThuCung()
            };
            return View(ViewIndex);
         }

        [Route ("/logout", Name = "logout")]
         
        public IActionResult Logout()  
        {  
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            var session = HttpContext.Session;

            session.Clear();

            return RedirectToAction (nameof (Index));  
        }  

       
       
        [HttpGet]
         public IActionResult Regsister()
         {
             var ViewModel = new KhachHangDTO()
             {
                GetAllLoai=homeService.LoaiThuCung(),

                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),

                GetThuCung=cartService.GetThuCung(),
             };

            return View(ViewModel);
         }

        [HttpPost]
        public IActionResult  Regsister(KhachHangDTO nguoiDung)
        {
             if (ModelState.IsValid)
            {
                if (nguoidungService.CheckTaiKhoan(nguoiDung.UserName))
                {
                    ViewBag.TB = "Tên Đăng Nhập Đã Tồn Tại";
                } else
                {
                    HttpContext.Session.SetString("VaiTro", nguoiDung.UserName + "");

                    HttpContext.Session.SetString("TenUser", nguoiDung.TenUser + "");

                    HttpContext.Session.SetString("Email", nguoiDung.Email + "");

                    HttpContext.Session.SetString("SDT", nguoiDung.SoDienThoai + "");

                    HttpContext.Session.SetString("DiaChi", nguoiDung.DiaChi + "");

                    //Create the identity for the user  
                    var identity = new ClaimsIdentity(new[] {  
                        new Claim(ClaimTypes.Name, nguoiDung.UserName)  
                    }, CookieAuthenticationDefaults.AuthenticationScheme);  
    
                    var principal = new ClaimsPrincipal(identity);  
    
                    var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);  
                    ViewBag.UserName=nguoiDung.UserName;

                    nguoidungService.Create(nguoiDung);

                    ViewBag.TC = "Đăng Ký Thành Công";
                    
                    return RedirectToAction("Index");
                }
            }

             var ViewModel = new KhachHangDTO()
             {
                 GetAllLoai=homeService.LoaiThuCung(),
                GetThuCung=cartService.GetThuCung(),
                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro"))

             };
            return View(ViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
