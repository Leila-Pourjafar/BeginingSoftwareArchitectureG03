﻿using HouseRent.Core.Domain.Framework;

namespace HouseRent.Core.Domain.Homes.Entities;

public static class HomeErrors
{
    public static Error NotFound = new(
        "Home.NotFound",
        "خانه ای با شناسه ارسال شده یافت نشد");
}