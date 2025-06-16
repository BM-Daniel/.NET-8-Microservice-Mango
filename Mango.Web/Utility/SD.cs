namespace Mango.Web.Utility
{
    // SD - Static Details
    public class SD
    {
        public static string CouponAPIBase { get; set; }
        public static string ProductAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public static string ShoppingCartAPIBase { get; set; }
        public static string OrderAPIBase { get; set; }

        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";


        // an enum is used to represent a collection of related constants
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }
    }
}
