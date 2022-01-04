using Bán_Hàng_Onl_WebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bán_Hàng_Onl_WebForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Sign_In()
        {
            return View();
        }

        public ActionResult Sign_Up(int UserID = 0)
        {
            User user = new User();
            return View(user);
        }

        //[HttpPost]
        public ActionResult Autherize(Bán_Hàng_Onl_WebForm.Models.User user1)
        {
            //user1.LoginSuccess = "";
            using(Final_projectEntities2 db = new Final_projectEntities2())
            {
                var userDetail = db.Users.Where(x => x.UserName == user1.UserName && x.Password == user1.Password).FirstOrDefault();
                if(userDetail == null)
                {
                    user1.LoginError = "Bạn đã nhập sai tài khoản hoặc mật khẩu ";
                    return View("Sign_In",user1);
                }
                else
                {
                    Session["FullName"] = userDetail.FullName;
                    Session["UserID"] = userDetail.UserID;
                    Session["UserName"] = userDetail.UserName;

                    DateTime Birth= (DateTime)userDetail.birthday;
                    Session["Birthday"] = Birth.ToString("dd/MM/yyyy");

                    Session["Email"] = userDetail.Email;
                    Session["Phone"] = userDetail.phone;
                    if ((Boolean)userDetail.gender)
                    {
                        Session["Gender"] = "Nữ";
                    }
                    else
                    {
                        Session["Gender"] = "Nam";
                    }
                    return RedirectToAction("Index", "Catelogy");
                }
            }
            return View();
        }

        //[HttpPost]
        public ActionResult addToDB(Bán_Hàng_Onl_WebForm.Models.User user)
        {

            using(Final_projectEntities2 db  = new Final_projectEntities2())
            {
                if(db.Users.Any( x=> x.UserName == user.UserName))
                {
                    user.RegisterFail = "Tài khoản đã tồn tại!";
                    return View("Sign_Up", user);
                }
                if(user.Password != user.ConfrimPassword)
                {
                    user.RegisterFail = "Mật khẩu xác nhận không khớp!";
                    return View("Sign_Up", user);
                }
                user.status = true;
                db.Users.Add(user);
                db.SaveChanges();
                user.RegisterFail = "Đăng kí thành công !";
                Session["FullName"] = user.FullName;
                Session["UserID"] = user.UserID;
                Session["UserName"] = user.UserName;

                DateTime Birth = (DateTime)user.birthday;
                Session["Birthday"] = Birth.ToString("dd/MM/yyyy");

                Session["Email"] = user.Email;
                Session["Phone"] = user.phone;
                if ((Boolean)user.gender)
                {
                    Session["Gender"] = "Nữ";
                }
                else
                {
                    Session["Gender"] = "Nam";
                }
                return RedirectToAction("Index", "Catelogy");
            }
            ModelState.Clear();
            
            return View("addToDB",new User());
        }

        public ActionResult LogOut()
        { 
            Session.Abandon();
            return RedirectToAction("Sign_In", "Login");
        }
    }
}