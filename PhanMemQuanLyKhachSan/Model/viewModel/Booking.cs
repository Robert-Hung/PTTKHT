namespace PhanMemQuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    
    public partial class Booking
    {
        public static List<Booking> GetAll()
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.Bookings.ToList();
        }
        public static Booking GetBooking(int bookingid)
        {
            QuanLyKhachSanEntities context = new QuanLyKhachSanEntities();
            return context.Bookings.Where(p => p.BookingID == bookingid).FirstOrDefault();
        }
    }
}
