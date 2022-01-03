﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        LaptopStoreManegement db = new LaptopStoreManegement();

        // GET: Sanpham
        public ActionResult lapHPpartial()
        {
            var hp = db.Sanphams.Where(n=>n.Mahang==2).Take(4).ToList();
           return PartialView(hp);
        }
        public ActionResult lapASUSpartial()
        {
            var asus = db.Sanphams.Where(n => n.Mahang == 6).Take(4).ToList();
            return PartialView(asus);
        }
        public ActionResult lapMACBOOKpartial()
        {
            var mac = db.Sanphams.Where(n => n.Mahang == 8).Take(4).ToList();
            return PartialView(mac);
        }

        public ActionResult lapMSIpartial()
        {
            var msi = db.Sanphams.Where(n => n.Mahang == 7).Take(4).ToList();
            return PartialView(msi);
        }

        public ActionResult lapAcerpartial()
        {
            var acer = db.Sanphams.Where(n => n.Mahang == 10).Take(4).ToList();
            return PartialView(acer);
        }
        public ActionResult lapSamSungpartial()
        {
            var samsung = db.Sanphams.Where(n => n.Mahang == 11).Take(4).ToList();
            return PartialView(samsung);
        }

        public ActionResult lapLenovopartial()
        {
            var lenovo = db.Sanphams.Where(n => n.Mahang == 9).Take(4).ToList();
            return PartialView(lenovo);
        }

        public ActionResult showLapVanPhong()
        {
            var lapVP = db.Sanphams.Where(x => x.Maloai == 1).ToList();
            return View(lapVP);
        }
        public ActionResult showLapGaming()
        {
            var lapGM = db.Sanphams.Where(x => x.Maloai == 2).ToList();
            return View(lapGM);
        }
        public ActionResult showLapDoanhNhanh()
        {
            var lapDN = db.Sanphams.Where(x => x.Maloai == 3).ToList();
            return View(lapDN);
        }

        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}