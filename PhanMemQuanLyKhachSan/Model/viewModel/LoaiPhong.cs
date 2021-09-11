namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    
    public partial class LoaiPhong
    {
        public static List<LoaiPhong> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.LoaiPhongs.ToList();
        }
        public static LoaiPhong GetLoaiPhong(int idLoaiPhong)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.LoaiPhongs.Where(p => p.LoaiPhongID == idLoaiPhong).FirstOrDefault();
        }
    }
}
