using System;
using System.Collections.Generic;
using System.Linq;
using Application.DTOs;
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcPet.Models;
using Newtonsoft.Json;


namespace mvcPet.Controllers
{
    
    public class ThuCungController: Controller
    {
       
        private readonly ITempService tempService;
        private readonly IThuCungService thucungService;
        private readonly ICartService cartService;
        private readonly IHoaDonService hoaDonService;
        private readonly IChiTietHoaDonService cthoaDonService;

        private readonly PetContext petContext;
        public ThuCungController( PetContext petContext,ITempService tempService,IChiTietHoaDonService cthoaDonService,IThuCungService thucungService,ICartService cartService,IHoaDonService hoaDonService)
        {
            this.cthoaDonService=cthoaDonService;
            this.thucungService= thucungService;
            this.cartService= cartService;
            this.hoaDonService = hoaDonService;
            this.petContext=petContext;
            this.tempService=tempService;
        }

        [Route ("/thucung", Name = "thucung")]
        public ActionResult Index(string sortOrder,string searchString,int? page=0)
        {
            int limit=6;
            int start;
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            start = (int)(page - 1) * limit;
 
            ViewBag.pageCurrent = page;
 
            int totalProduct = thucungService.totalProduct();
 
            ViewBag.totalProduct = totalProduct;
 
            ViewBag.numberPage = thucungService.numberPage(totalProduct, limit);
            var ViewThuCungIndex= new ThuCungViewModel()
            {
                GetAllLoai =thucungService.GetAll(),
                banner= thucungService.GetBanner(),
                sortOrder=sortOrder,
                SearchString=searchString,
                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),
                GetThuCung=cartService.GetThuCung(),
                PageList = thucungService.paginationProduct(start, limit,sortOrder,searchString)
            };
            return View(ViewThuCungIndex);
        }

        [Route ("/chitiet", Name = "chitiet")]
        public ActionResult Detail(int Id,string sortOrder,string searchString,float GiaBan,int? page=0)
        {
            int limit=15;
            int start;
            if (page > 0)
            {
                page = page;
            }
            else
            {
                page = 1;
            }
            start = (int)(page - 1) * limit;
 
            ViewBag.pageCurrent = page;
 
            int totalProduct = thucungService.totalPetProduct();
 
            ViewBag.totalProduct = totalProduct;
 
            ViewBag.numberPage = thucungService.PetnumberPage(totalProduct, limit);
             var ViewThuCungIndex= new ThuCungViewModel()
            {
                GetAllLoai =thucungService.GetAll(),
                // PagePetList= thucungService.paginationPetProduct(Id,start, limit,sortOrder),
                thuCungs= thucungService.GetThuCungDTOs(Id,start, limit,sortOrder,searchString,GiaBan),
                
                sortOrder=sortOrder,
                
                SearchString=searchString,
                
                GiaBan=GiaBan,
                
                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),
                
                GetThuCung=cartService.GetThuCung(),
                
                banner= thucungService.GetBanner()
            };
            return View(ViewThuCungIndex);
        }
        [Route ("/thongtin", Name = "thongtin")]
        public ActionResult PetDetails(int id)
        {
             var ViewThuCungIndex= new ThuCungViewModel()
            {
               GetThuCungg= thucungService.GetBy(id),

               thuCung=thucungService.GetThuCungs(),

               GetAllLoai =thucungService.GetAll(),

               GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),

               GetThuCung=cartService.GetThuCung()

            };

            return View(ViewThuCungIndex);
        }

       
        

        
        public IActionResult AddToCart(int id,[FromForm] int quantity=1)
        {
        if (HttpContext.Session.GetString("VaiTro") != null )
        {
            int soluong = cartService.GetSl(HttpContext.Session.GetString("VaiTro"),id);

            if(cartService.CheckTaiKhoan(HttpContext.Session.GetString("VaiTro"),id) )
            {
                soluong+=quantity;
                cartService.UpdateToDB(HttpContext.Session.GetString("VaiTro"),id,soluong);
            }
            else
            {
                cartService.AddCartToDB(id,quantity,HttpContext.Session.GetString("VaiTro"));
            }
            return RedirectToAction (nameof (_Cart));
            }
            return Redirect(@"~/Home/Login");
        }


       
        [Route ("/cart", Name = "cart")]

         public ActionResult _Cart()
        {
            
            
            if (HttpContext.Session.GetString("VaiTro") != null )
            {
                List<CartDBDTO> vm =  new List<CartDBDTO>();
                var items =  petContext.Carts.Where(m => m.User==HttpContext.Session.GetString("VaiTro") ).ToList();;
            
                    foreach(var item in items)
                    {
                        // var name = petContext.thuCungs.Single(m => m.IdThuCung==item.Id);
                        var name = thucungService.GetSingerThuCung(item.Id);
                        float dongia= name.GiaBan;

                        string tenthucung = name.TenThuCung;
                        string image = name.Image;
                        
                        vm.Add( new CartDBDTO
                            {
                                CartId=item.CartId,
                                Id=item.Id,
                                Quantity=item.Quantity,
                                User=item.User,
                                TenThuCung=tenthucung,
                                image=image,
                                DonGia=dongia
                        });
                    
                    }
                return PartialView("~/Views/Shared/_Cart.cshtml",vm);
            }
            return Redirect(@"~/Home/Login");
        } 

        public IActionResult DeleteThuCung( List<CartDBDTO> emp,[FromForm] float GiaBan)
        {

            
           

            List<CartDB> employ = new List<CartDB>();
            HoaDonDTO hoadon = new HoaDonDTO()
                    {
                        NgayLap= Convert.ToDateTime(DateTime.Today.ToShortDateString()),
                        SoLuongMua= 0,
                        TongTien= 0,
                        IdKhachHangUserName =HttpContext.Session.GetString("VaiTro"),
                        IdTrangThai =3
                    };
            
            hoaDonService.Create(hoadon);
            foreach(var item in emp)
            {
                if(item.Emps.Selected)
                {
                    CartDB selectemloy= petContext.Carts.Find(item.CartId);
                    petContext.SaveChanges();
                    employ.Add(selectemloy);

                    petContext.SaveChanges();

                    var name = petContext.thuCungs.Single(m => m.IdThuCung==selectemloy.Id);

                    float dongia= name.GiaBan;
                     

                     ChiTietHoaDonDTO cthd = new ChiTietHoaDonDTO()
                    {
                        IdThuCung = selectemloy.Id,
                        
                        IdHoaDon= hoaDonService.GetIdHoaDOn(),

                        SoLuong=selectemloy.Quantity,

                        ThanhTien=selectemloy.Quantity*dongia

                    };
                    Tempt temp = new Tempt()
                    {
                        IdHoaDon=hoaDonService.GetIdHoaDOn(),

                        IdThuCung = selectemloy.Id,

                        SoLuong=selectemloy.Quantity
                        
                    };
                    petContext.Temp.Add(temp);
                    cthoaDonService.Create(cthd);
                    cartService.RemoveCartToDB(selectemloy.Id,HttpContext.Session.GetString("VaiTro"));

                    int IdLoaiThuCung= petContext.thuCungs.Single(m => m.IdThuCung==selectemloy.Id).IdLoaiThuCung;
                    LoaiThuCung loai = petContext.loaiThuCungs.Find(IdLoaiThuCung);
                    loai.SoLuong = loai.SoLuong-1;
                    petContext.SaveChanges();

                    ThuCung thucung = petContext.thuCungs.Find(selectemloy.Id);
                    thucung.IsFeatured=false;
                    petContext.SaveChanges();
                   
                }
                else
                {
                    ViewData["er"] = "Đăng Ký Thành Công";

                    return RedirectToAction("_Cart");
                }
              
            }
            int totalSL = cthoaDonService.SumSoLuong(hoaDonService.GetIdHoaDOn());

            float totalTT = cthoaDonService.SumTongTien(hoaDonService.GetIdHoaDOn());

            hoaDonService.UpdateHoaDon(hoaDonService.GetIdHoaDOn(),totalSL,totalTT);
            return RedirectToAction("CheckOut");
        }


        [Route ("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart ([FromForm] int productid, [FromForm] int quantity) 
        {
            // Cập nhật Cart thay đổi số lượng quantity ...

            if (cartService.CheckTaiKhoan(HttpContext.Session.GetString("VaiTro"),productid)) 
            {
                cartService.UpdateToDB(HttpContext.Session.GetString("VaiTro"),productid,quantity);
            }
             return RedirectToAction (nameof (_Cart));
        }

        /// xóa item trong cart
        [Route ("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart ([FromRoute] int productid) {
          
            if (cartService.CheckTaiKhoan(HttpContext.Session.GetString("VaiTro"),productid)) {
                // Đã tồn tại, tăng thêm 1
                cartService.RemoveCartToDB(productid,HttpContext.Session.GetString("VaiTro"));
            }
            return RedirectToAction (nameof (_Cart));
        }

       
        [HttpGet]
        //   [Route ("/checkout", Name = "checkout")]
        public IActionResult Checkout()
        {
              
            if (HttpContext.Session.GetString("VaiTro") != null )
            {
            var CartIndex= new HoaDonViewModel()
            {
                getHoaDon=hoaDonService.GetHoaDon(HttpContext.Session.GetString("VaiTro")),  

                GetTrangThai=hoaDonService.GetTrangThai(),
                
                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),

                GetThuCung=cartService.GetThuCung(),

                GetAllLoai =cartService.GetAll(),

                GetCheckOut=cartService.GetCheckOut(HttpContext.Session.GetString("VaiTro"))
            };
            
            return View(CartIndex);
            }
            return Redirect(@"~/Home/Login");
        }

        
        public IActionResult ViewBills(int idhoadon)
        {
            if (HttpContext.Session.GetString("VaiTro") != null )
            {
            var cthdvm = new ChiTietHoaDonViewModel()
            {
                GetAllLoai =thucungService.GetAll(),

                GetCart=cartService.GetCart(HttpContext.Session.GetString("VaiTro")),

                GetThuCung=cartService.GetThuCung(),

                GetCTHD=tempService.GetChiTietHoaDons(idhoadon),

                GetThuCungg=tempService.GetThuCungs()
            };

                return View(cthdvm);
            }
            return Redirect(@"~/Home/Index");
            
        }   

        
        public IActionResult Cancel(int idhoadon)
        {
            hoaDonService.UpdateCancel(idhoadon);
            var data= petContext.Temp.Where(m => m.IdHoaDon==idhoadon).ToList();
            var listpet= petContext.thuCungs.ToList();;
            foreach(var item in data)
            {
                foreach(var item1 in listpet)
                {
                        if(item1.IdThuCung==item.IdThuCung)
                        {
                            int IdLoaiThuCung= petContext.thuCungs.Single(m => m.IdThuCung==item1.IdThuCung).IdLoaiThuCung;
                            LoaiThuCung loai = petContext.loaiThuCungs.Find(IdLoaiThuCung);
                            loai.SoLuong=loai.SoLuong+1;
                            petContext.SaveChanges();
                            // cthoaDonService.Remove(idhoadon);
                            thucungService.UpDateFeatured(item.IdThuCung);
                        }
                }
            }
            return RedirectToAction("Checkout");   
        }
        
    }
}