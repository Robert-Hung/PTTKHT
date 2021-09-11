namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

   
    public partial class ChiTietHoaDon
    {
        public static List<ChiTietHoaDon> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.ChiTietHoaDons.ToList();
        }
        public static ChiTietHoaDon GetChiTietHoaDon(int cthdId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.ChiTietHoaDons.Where(p => p.ChiTietHoaDonID == cthdId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.ChiTietHoaDons.AddOrUpdate(this);
            context.SaveChanges();
        }


    }
}
