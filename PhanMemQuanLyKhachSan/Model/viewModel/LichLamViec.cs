namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    
    public partial class LichLamViec
    {
        public static List<LichLamViec> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.LichLamViecs.ToList();
        }
        public static LichLamViec GetLichLamViec(int lichLamViecId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.LichLamViecs.Where(p => p.LichLamViecID == lichLamViecId).FirstOrDefault();
        }
        //?ang x? lý
        public static List<LichLamViec> GetLichLamViecHienTai(string ngayHienTai)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.LichLamViecs.Where(p => p.Ngay == ngayHienTai).ToList();
        }
        public void InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.LichLamViecs.AddOrUpdate(this);
            context.SaveChanges();
        }
        public static void Delete(int id)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            LichLamViec db = context.LichLamViecs.Where(p => p.LichLamViecID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.LichLamViecs.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
