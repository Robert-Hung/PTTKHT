namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

   

    public partial class HoaDon
    {
        public static List<HoaDon> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.HoaDons.ToList();
        }
        public static HoaDon GetHoaDon(int hoaDonId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.HoaDons.Where(p => p.HoaDonID == hoaDonId).FirstOrDefault();
        }
        public static HoaDon GetHoaDonByPhong(int? phongId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.HoaDons.LastOrDefault(p => p.PhongID == phongId);

        }
        
        public int InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.HoaDons.AddOrUpdate(this);
            return context.SaveChanges();
        }
    }
}
