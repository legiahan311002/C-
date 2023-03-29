using QLNhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNhanVien.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien = new DBNhanVienContext().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien/Details/5
        public ActionResult Permission(int id)
        {
            var context = new DBNhanVienContext();
            var editing = context.NhanViens.Find(id);
            return View(editing);
        }
        // POST: Permission/Edit/5
        [HttpPost]
        public ActionResult Permission(NhanVien model)
        {
            try
            {
                // TODO: Add update permissions logic here
                var context = new DBNhanVienContext();
                var oldItem = context.NhanViens.Find(model.Id);
                oldItem.MatKhau = model.MatKhau;
                oldItem.LaQuanTri = model.LaQuanTri;
                oldItem.LaChuyenVien = model.LaChuyenVien;
                oldItem.LaNhanVien = model.LaNhanVien;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            var context = new DBNhanVienContext();
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = chucVuSelect;
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBNhanVienContext();
                context.NhanViens.Add(model);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBNhanVienContext();
            var editing = context.NhanViens.Find(id);
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu",editing.IdChucVu);
            ViewBag.IdChucVu = chucVuSelect;
            return View(editing);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBNhanVienContext();
                var oldItem = context.NhanViens.Find(model.Id);
                oldItem.HoVaTen = model.HoVaTen;
                oldItem.GioiTinh = model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.SoCanCuoc = model.SoCanCuoc;
                oldItem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBNhanVienContext();
            var deleting  = context.NhanViens.Find(id);
            return View(deleting);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

                // TODO: Add delete logic here
                var context = new DBNhanVienContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
