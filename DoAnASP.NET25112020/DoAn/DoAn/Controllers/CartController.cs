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





    }
}
