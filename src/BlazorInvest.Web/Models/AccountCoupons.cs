namespace BlazorInvest.Web.Models;

public record AccountCoupons(string Name, Coupon[] UpcomingCoupons, Coupon[] PaidCoupons);
