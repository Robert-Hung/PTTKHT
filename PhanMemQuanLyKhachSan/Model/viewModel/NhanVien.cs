namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    

    public partial class NhanVien
    {
        public static List<NhanVien> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.NhanViens.ToList();
        }
        public static NhanVien GetNhanVien(int idNhanVien)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.NhanViens.Where(p => p.NhanVienID == idNhanVien).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.NhanViens.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            NhanVien db = context.NhanViens.Where(p => p.NhanVienID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.NhanViens.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
