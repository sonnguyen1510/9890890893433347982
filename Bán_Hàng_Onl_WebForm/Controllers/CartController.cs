using Bán_Hàng_Onl_WebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
namespace Bán_Hàng_Onl_WebForm.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        public JsonResult Update(String CartModel)
        {
            var Jsoncart = new JavaScriptSerializer().Deserialize<List<CartItem>>(CartModel);
            var Sessioncart = (List<CartItem>)Session[CartSession];
               
            foreach(var item in Sessioncart)
            {
                var jsonItem = Jsoncart.SingleOrDefault(x => x.Product.productID == item.Product.productID);
                if(jsonItem != null)
                {
                    item.Quantity = jsonItem.Quantity;
                }
            }
            Session[CartSession] = Sessioncart;
            return Json(new
            {
                status = true 
            });
        }

        public  JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }
        //[HttpGet]
        public ActionResult payment()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult payment(String CustomerName , String Phone,String Address)
        {
            var cart = (List<CartItem>)Session[CartSession];
            int count = 0;
            decimal id;
            
            foreach (var item in cart)
            {
                count = (int)(count + (item.Quantity*item.Product.Productprice));
            }
            try
            {
                using (Final_projectEntities2 db = new Final_projectEntities2())
                {

                    var order = new Order();
                    order.OrderDate = DateTime.Now;
                    order.UserID = (decimal)Session["UserID"];
                    order.FullName = CustomerName;
                    order.Address = Address;
                    order.Phone = Phone;
                    order.status = true;
                    order.Totalprice = count;
                    db.Orders.Add(order);
                    db.SaveChanges();
                    id = (decimal)order.OrderID;

                }
                using (Final_projectEntities2 db = new Final_projectEntities2())
                {
                    foreach (var item in cart)
                    {
                        var cartdetail = new Cart();
                        cartdetail.OrderID = id;
                        cartdetail.productID = item.Product.productID;
                        cartdetail.price = (decimal)item.Product.Productprice;
                        cartdetail.quantity = item.Quantity;

                        db.Carts.Add(cartdetail);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Sussess", "Cart");
            }
            catch (Exception ex) {
                return RedirectToAction("Fail", "Cart");
            }

            
        }

        public ActionResult Sussess()
        {
            return View();
        }

        public ActionResult Fail()
        {
            return View();
        }


        public ActionResult AddItem(int productID , int quantity)
        {
            var session = Session[CartSession];
            using (Final_projectEntities2 db = new Final_projectEntities2())
            {
                var product = db.Products.Where(x => x.productID == productID).FirstOrDefault();

                if (session != null)
                {
                    var list = (List<CartItem>)session;
                    if (list.Exists(x => x.Product.productID == productID))
                    {
                        foreach (var item in list)
                        {
                            if (item.Product.productID == productID)
                            {
                                item.Quantity = item.Quantity + 1;
                            }

                        }
                    }
                    else
                    {
                        var item = new CartItem();
                        item.Product = product;
                        item.Quantity = quantity;
                        list.Add(item);
                    }
                    Session[CartSession] = list;
                }
                else
                {

                    var item = new CartItem();
                    item.Product = product;
                    item.Quantity = quantity;
                    var list = new List<CartItem>();
                    list.Add((CartItem)item);

                    Session[CartSession] = list;
                }
                return RedirectToAction("Index");
            }
        }
    }
}