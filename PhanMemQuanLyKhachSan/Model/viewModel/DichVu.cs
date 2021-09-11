namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;


    public partial class DichVu
    {
        public int SoLuong =0;
        public int ThanhTien=0; 

        public static List<DichVu> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.DichVus.ToList();
        }
        public static DichVu GetDichVu(int dichVuId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.DichVus.Where(p => p.DichVuID == dichVuId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.DichVus.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            DichVu db = context.DichVus.Where(p => p.DichVuID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.DichVus.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
