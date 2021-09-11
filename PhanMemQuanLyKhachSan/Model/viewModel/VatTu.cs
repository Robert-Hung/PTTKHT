namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

  
    public partial class VatTu
    {
        public static List<VatTu> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.VatTus.ToList();
        }
        public static VatTu GetVatTu(int vatTuId)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.VatTus.Where(p => p.VatTuID == vatTuId).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            context.VatTus.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            VatTu db = context.VatTus.Where(p => p.VatTuID == id).FirstOrDefault();
            if (db != null)
            {
                //  context.Students.Attach(db);
                context.VatTus.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
