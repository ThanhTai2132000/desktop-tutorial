using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn.Areas.Admin.Data;
using DoAn.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DoAn.Controllers
{
    public class CartController : Controller
    {
        private readonly DPContext _context;

        public CartController(DPContext context)
        {
            _context = context;
        }
        public List<DienThoaiModel> getAllProduct()
        {
            return _context.DienThoai.ToList();
        }

        //GET DETAIL PRODUCT
        public DienThoaiModel getDetailProduct(int id)
        {
            var product = _context.DienThoai.Find(id);
            return product;
        }
        public IActionResult addCart(int id)
        {
            try
            {
                JObject acc = JObject.Parse(HttpContext.Session.GetString("accountuser"));
                ViewBag.account = acc.SelectToken("TenTK").ToString();
            }
            catch
            {
                return RedirectToAction("Index","Login");
            }
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart == null)
            {
                var product = getDetailProduct(id);
                List<CartModel> listCart = new List<CartModel>()
               {
                   new CartModel
                   {
                       DienThoai = product,
                       Quantity = 1
                   }
               };
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(listCart));

            }
            else
            {
                List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);
                bool check = true;
                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].DienThoai.ID == id)
                    {
                        dataCart[i].Quantity++;
                        check = false;
                    }
                }
                if (check)
                {
                    dataCart.Add(new CartModel
                    {
                        DienThoai = getDetailProduct(id),
                        Quantity = 1
                    });
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                // var cart2 = HttpContext.Session.GetString("cart");//get key cart
                //  return Json(cart2);
            }

            return RedirectToAction("List", "Home");
        }
        public IActionResult ListCart()
        {
            JObject acc;
            try
            {
                if (HttpContext.Session.GetString("account") != null)
                {
                    acc = JObject.Parse(HttpContext.Session.GetString("account"));
                }
                else acc = JObject.Parse(HttpContext.Session.GetString("accountuser"));

                ViewBag.account = acc.SelectToken("TenTK").ToString();

                
            }
            catch
            {
                ViewBag.account = null;
            }
            var cart = HttpContext.Session.GetString("cart");//get key cart
            if (cart != null)
            {
                List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);
                if (dataCart.Count > 0)
                {
                    ViewBag.carts = dataCart;
                    return View();
                }
            }
            return View("../Cart/ListCart");
        }
        [HttpPost]
        public IActionResult updateCart(int id, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);
                if (quantity > 0)
                {
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].DienThoai.ID == id)
                        {
                            dataCart[i].Quantity = quantity;
                        }
                    }


                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                }
                var cart2 = HttpContext.Session.GetString("cart");
                return Ok(quantity);
            }
            return BadRequest();

        }
        public IActionResult deleteCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);

                for (int i = 0; i < dataCart.Count; i++)
                {
                    if (dataCart[i].DienThoai.ID == id)
                    {
                        dataCart.RemoveAt(i);
                    }
                }
                HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(dataCart));
                return RedirectToAction(nameof(ListCart));
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<bool> ThanhToan()
        {

            int getHoaDon = _context.HoaDon.Count();


            var acc = HttpContext.Session.GetString("account");

            if (acc == null)
            {
                acc = HttpContext.Session.GetString("accountuser");
            }

            var cart = HttpContext.Session.GetString("cart");
            if (cart == null || acc == null)
            {

                return false;
            }
            else if (cart != null && acc != null)
            {
                JObject TaiKhoanModel = JObject.Parse(acc);
                string tentk = TaiKhoanModel.SelectToken("TenTK").ToString();
                HoaDonModel hoadon = new HoaDonModel();


                if (getHoaDon != 0)
                {
                    int idhoadon = int.Parse(_context.HoaDon.OrderBy(h => h.MaHD).Last().MaHD); //Lấy ID ở dòng cuối cùng trong bảng
                    int nextID = ++idhoadon; //ID của dòng được thêm mới


                    List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);
                    float tongtien = 0;
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].DienThoai.GiaKM != 0)
                            tongtien += dataCart[i].DienThoai.GiaKM * dataCart[i].Quantity;
                        else tongtien += dataCart[i].DienThoai.DonGia * dataCart[i].Quantity;
                    }

                    //Thêm vào bảng HoaDon
                    hoadon.MaHD = nextID.ToString();
                    hoadon.MaTK = tentk;
                    hoadon.NgayLapHD = DateTime.Now;
                    hoadon.TongTien = tongtien;
                    _context.Add(hoadon);
                    await _context.SaveChangesAsync();
                    



                    //Thêm vào bảng ChiTietHoaDon

                    ChiTietHoaDonModel chiTietHoaDon = new ChiTietHoaDonModel();

                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        chiTietHoaDon.MaHoaDon = nextID.ToString();
                        chiTietHoaDon.IDDienThoai = dataCart[i].DienThoai.ID;
                        chiTietHoaDon.SoLuong = dataCart[i].Quantity;
                        chiTietHoaDon.DonGia = dataCart[i].DienThoai.DonGia;
                        chiTietHoaDon.GiaKhuyenMai = dataCart[i].DienThoai.GiaKM;
                        _context.Add(chiTietHoaDon);
                        await _context.SaveChangesAsync();
                        chiTietHoaDon = new ChiTietHoaDonModel();
                    }
                    
                    

                    HttpContext.Session.Remove("cart");
                    return true;
                }
                else
                {

                    int nextID = 1;


                    List<CartModel> dataCart = JsonConvert.DeserializeObject<List<CartModel>>(cart);
                    float tongtien = 0;
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        if (dataCart[i].DienThoai.GiaKM != 0)
                            tongtien += dataCart[i].DienThoai.GiaKM * dataCart[i].Quantity;
                        else tongtien += dataCart[i].DienThoai.DonGia * dataCart[i].Quantity;
                    }

                    hoadon.MaHD = nextID.ToString();
                    hoadon.MaTK = tentk;
                    hoadon.NgayLapHD = DateTime.Now;
                    hoadon.TongTien = tongtien;
                    _context.Add(hoadon);
                    await _context.SaveChangesAsync();

                    //Thêm vào bảng ChiTietHoaDon
                    
                    ChiTietHoaDonModel chiTietHoaDon = new ChiTietHoaDonModel();
                    for (int i = 0; i < dataCart.Count; i++)
                    {
                        
                        chiTietHoaDon.MaHoaDon = nextID.ToString();
                        chiTietHoaDon.IDDienThoai = dataCart[i].DienThoai.ID;
                        chiTietHoaDon.SoLuong = dataCart[i].Quantity;
                        chiTietHoaDon.DonGia = dataCart[i].DienThoai.DonGia;
                        chiTietHoaDon.GiaKhuyenMai = dataCart[i].DienThoai.GiaKM;
                        _context.Add(chiTietHoaDon);
                        await _context.SaveChangesAsync();
                        chiTietHoaDon = new ChiTietHoaDonModel();
                    }
                    
                    

                    HttpContext.Session.Remove("cart");
                    return true;
                }



            }
            return false;

        }


    }
}
