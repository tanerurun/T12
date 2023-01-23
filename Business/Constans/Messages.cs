using Entities.Concrete;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductNameInValid = "urun ismi gecersiz";

        public static string ProductAdded = "Uurun eklendi.";

        public static List<Product> MaintenanceTime { get; internal set; }
        public static string ProductListeted { get; internal set; }
    }
}
