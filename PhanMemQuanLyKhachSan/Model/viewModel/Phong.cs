namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

   
    public partial class Phong
    {
        public static List<Phong> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.Phongs.ToList();
        }
        public static List<Phong> GetAll(int loaiPhong)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.Phongs.Where(p => p.LoaiPhongID == loaiPhong).ToList();
        }
        public static Phong GetPhong(int vatTuId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.Phongs.Where(p => p.PhongID == vatTuId).FirstOrDefault();

        }

    }
}
