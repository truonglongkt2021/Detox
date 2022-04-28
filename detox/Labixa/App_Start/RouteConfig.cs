using Labixa.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Labixa
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //routes.MapRoute("ChiTietTaiLieu", "tai-lieu/{slug}", new { controller = "Home", action = "Detail", slug = UrlParameter.Optional });
            //routes.MapRoute("TrangChu", "", new { controller = "Home", action = "Index", slug = UrlParameter.Optional });
            //routes.MapRoute("GioiThieu", "gioi-thieu", new { controller = "Home", action = "GioiThieu", slug = UrlParameter.Optional });
            //routes.MapRoute("redirect", "RedirectMomo", new { controller = "Home", action = "RedirectMomo"});
            //routes.MapRoute("TinTuc", "tin-tuc", new { controller = "Home", action = "TinTuc", slug = UrlParameter.Optional });
            //routes.MapRoute("ChiTietTinTuc", "chi-tiet-tin-tuc/{slug}", new { controller = "Home", action = "ChiTietTinTuc", slug = UrlParameter.Optional });
            //routes.MapRoute("DanhMucTaiLieu", "danh-muc/{slug}", new { controller = "Home", action = "IndexCategory", slug = UrlParameter.Optional });
            //routes.MapRoute("ChinhSachHoTro", "chinh-sach-ho-tro/{slug}", new { controller = "Home", action = "HoTro", slug = UrlParameter.Optional });
            routes.MapRoute("CuaHang", "cua-hang/{slug}", new { controller = "ShopProduct", action = "Product", slug = UrlParameter.Optional });
            routes.MapRoute("TinTuc", "tin-tuc", new { controller = "ShopNews", action = "News", slug = UrlParameter.Optional });
            routes.MapRoute("ChiTietTinTuc", "tin-tuc/{slug}", new { controller = "ShopNews", action = "NewsDetail", slug = UrlParameter.Optional });
            routes.MapRoute("ChinhSach", "chinh-sach-cham-soc/{slug}", new { controller = "ShopHelp", action = "Help", slug = UrlParameter.Optional });
            routes.MapRoute("TrangChu", "", new { controller = "Shop", action = "Index", slug = UrlParameter.Optional });
            routes.MapRoute("VeChungToi", "ve-chung-toi", new { controller = "ShopAbout", action = "AboutUs", slug = UrlParameter.Optional });
            routes.MapRoute("LienHe", "lien-he", new { controller = "ShopContact", action = "Contact", slug = UrlParameter.Optional });
            routes.MapRoute("TimKiem", "tim-kiem", new { controller = "ShopProduct", action = "Search", slug = UrlParameter.Optional });
            routes.MapRoute("TimKiemBaiViet", "tim-kiem-bai-viet", new { controller = "ShopNews", action = "SearchBlog", slug = UrlParameter.Optional });
            routes.MapRoute("MuaHang", "mua-hang", new { controller = "ShopProduct", action = "Buy", slug = UrlParameter.Optional });
            routes.MapRoute("ThanhToan", "thanh-toan", new { controller = "ShopProduct", action = "Checkout", slug = UrlParameter.Optional });
            routes.MapRoute("ThanhToanMomo", "thanh-toan-momo", new { controller = "ShopProduct", action = "ThanhToanMomo", slug = UrlParameter.Optional });
            routes.MapRoute("ThanhToanThuong", "thanh-toan-thuong", new { controller = "ShopProduct", action = "ThanhToanTrucTuyen", slug = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {  controller = "Shop", action = "Index", id = UrlParameter.Optional }
            ); 

        }


    }
}
