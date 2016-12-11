using System;
using System.Linq;

namespace Hotel_Database.Data
{
    internal class Database
    {
        public static int UserAccess { get; set; }
        public static int UserID { get; set; }
        public static DateTime DateStart { get; set; }
        public static DateTime DateEnd { get; set; }
        public static int RoomID { get; set; }
        public static int Room_Charge { get; set; }

        // Global Variables Used When adding and updating bookings.
        public Database()
        {
        }

        public static bool CheckUser(string User, string Password)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var UserInfo = (from c in context.Logins where c.user == User select c).SingleOrDefault();
                try
                {
                    if (UserInfo.password == Password)
                    {
                        UserAccess = UserInfo.access;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static void CreateBooking()
        {
            using (var context = new HotelDatabaseEntities())
            {
                var New_Charge = new Charge();
                New_Charge.Room_Charge = Room_Charge;
                New_Charge.Total = Room_Charge;
                context.Charges.Add(New_Charge);
                context.SaveChanges();
                var New_Booking = new Booking();
                New_Booking.Room_IDFK = RoomID;
                New_Booking.Guest_IDFK = UserID;
                New_Booking.Charges_IDFK = New_Charge.ID;
                New_Booking.Booking_From = DateStart;
                New_Booking.Booking_To = DateEnd;
                New_Booking.Checked_In = false;
                context.Bookings.Add(New_Booking);
                context.SaveChanges();
                ClearValues();
                // our basic create a booking function
            }
        }

        public static void CreatGuest(string Name, string Address, string Mobile, string Home_Phone)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var New_Guest = new Guest_Info();
                New_Guest.Name = Name;
                New_Guest.Address = Address;
                New_Guest.Mobile = Mobile;
                New_Guest.Home_Phone = Home_Phone;
                context.Guest_Info.Add(New_Guest);
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void AddRoom(string Name, int Singles, int Doubles, string ExtraInfo)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var New_Room = new Room();
                New_Room.Room_Name = Name;
                New_Room.Single_Beds = Singles;
                New_Room.Double_Beds = Doubles;
                New_Room.Extra_Info = ExtraInfo;
                context.Rooms.Add(New_Room);
                context.SaveChanges();
                ClearValues();
            }
        }

        public static bool DeleteRoom(int ID)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Room = (from c in context.Rooms where c.ID == ID select c).SingleOrDefault();
                try
                {
                    context.Rooms.Remove(Room);
                    context.SaveChanges();
                    ClearValues();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    System.Windows.Forms.MessageBox.Show("Booking References Room, Cannot Remove."); // if a room is referenced by a booking, then the room cannot be removed
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteGuest(int ID)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Guest = (from c in context.Guest_Info where c.ID == ID select c).SingleOrDefault();
                try
                {
                    context.Guest_Info.Remove(Guest);
                    context.SaveChanges();
                    ClearValues();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    System.Windows.Forms.MessageBox.Show("Booking References Guest, Cannot Remove.");
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteBooking(int ID)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Booking = (from c in context.Bookings where c.ID == ID select c).SingleOrDefault();
                try
                {
                    context.Bookings.Remove(Booking);
                    context.SaveChanges();
                    ClearValues();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    System.Windows.Forms.MessageBox.Show("Booking References Something, Cannot Remove.");
                    return false;
                }
                return true;
            }
        }

        public static bool DeleteCharges(int ID)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Charges = (from c in context.Charges where c.ID == ID select c).SingleOrDefault();
                try
                {
                    context.Charges.Remove(Charges);
                    context.SaveChanges();
                    ClearValues();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException)
                {
                    System.Windows.Forms.MessageBox.Show("Booking References Charges, Cannot Remove.");
                    return false;
                }
                return true;
            }
        }

        public static void UpdateGuest(string Name, string Address, string Mobile, string Home_Phone)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Guest = (from c in context.Guest_Info where c.ID == UserID select c).FirstOrDefault();
                Guest.Name = Name;
                Guest.Address = Address;
                Guest.Mobile = Mobile;
                Guest.Home_Phone = Home_Phone;
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void UpdateRoom(string RoomName, int SingleBeds, int DoubleBeds, string ExtraInfo)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Room = (from c in context.Rooms where c.ID == RoomID select c).FirstOrDefault();
                Room.Room_Name = RoomName;
                Room.Single_Beds = SingleBeds;
                Room.Double_Beds = DoubleBeds;
                Room.Extra_Info = ExtraInfo;
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void UpdateRoomPricing(int Single, int Double, int ESingle, int EDouble)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Room_Prices = (from c in context.Room_Prices select c).FirstOrDefault();
                Room_Prices.Single_Price = Single;
                Room_Prices.Double_Price = Double;
                Room_Prices.Extra_Single_Price = ESingle;
                Room_Prices.Extra_Double_Price = EDouble;
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void UpdateCharges(int Bar, int Internet, int Phone, int Room, int Additional, string Info)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var Charges = (from c in context.Charges where c.ID == Room_Charge select c).FirstOrDefault();
                Charges.Bar_Charge = Bar;
                Charges.Internet_Charge = Internet;
                Charges.Phone_Charge = Phone;
                Charges.Room_Charge = Room;
                Charges.Additional_Charges = Additional;
                Charges.Additional_Charges_Info = Info;
                Charges.Total = Bar + Internet + Phone + Room + Additional; // Work out the total cost so that we can charge them at the end of their stay
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void UpdateBooking(DateTime BookingFrom, DateTime BookingTo, bool CheckedIn)
        {
            using (var context = new HotelDatabaseEntities())
            {
                var booking = (from c in context.Bookings where c.ID == UserID select c).FirstOrDefault();
                booking.Booking_From = BookingFrom;
                booking.Booking_To = BookingTo;
                booking.Checked_In = CheckedIn;
                context.SaveChanges();
                ClearValues();
            }
        }

        public static void ClearValues() // this is a safety i added on incase of expansion on this software, it resets our globals everytime we use them so we dont get some bad passover information.
        {
            UserID = 0;
            DateStart = DateTime.Now;
            DateEnd = DateTime.Now;
            RoomID = 0;
            Room_Charge = 0;
        }
    }
}