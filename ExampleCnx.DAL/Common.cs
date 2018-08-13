using System.Configuration;

namespace ExampleCnx.DAL
{
    public static class Common
    {
        public static string CN_NAME = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
    }
}
