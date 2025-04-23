using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Bookings.Entities;

public static class BookingErrors
{
    public static Error NotFound = new(
        "Booking.Found",
        "اجاره ای با شناسه ارسال شده یافت نشد");


    public static Error NotReserved = new(
        "Booking.NotReserved",
        "فقط اجاره های در حالت انتظار قابلیت تایید/رد دارند");

    public static Error NotConfirmed = new(
        "Booking.NotReserved",
        "فقط اجاره های در حالت تایید این قابلیت را دارند");

    public static Error NotFinished = new(
    "Booking.NotFinished",
    "تا پایان روز اجاره امکان تکمیل فرایند وجود ندارد.");

    public static Error AlreadyStarted = new(
        "Booking.AlreadyStarted",
        "اجاره خانه در حال حاضر شروع شده است");
    public static Error Overlap = new(
"Booking.Overlap",
"خانه منتخب در بازه زمانی مورد نظر در دسترس نیست");
}