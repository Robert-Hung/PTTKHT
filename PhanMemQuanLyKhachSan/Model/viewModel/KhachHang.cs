namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    
    public partial class KhachHang
    {
        public static List<KhachHang> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.KhachHangs.ToList();
        }
        public static KhachHang GetKhachHang(int khachHangId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.KhachHangs.Where(p => p.KhachHangID == khachHangId).FirstOrDefault();

        }
        public KhachHang InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            KhachHang kh = context.KhachHangs.Add(this);
            context.SaveChanges();
            return kh;
        }
    }
}
