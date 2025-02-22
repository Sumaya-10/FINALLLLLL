namespace WellFood.DAL.Helpers;

public static  class SqlHelper
{
    private static readonly string _connectionStr = @"Server=WIN-LIOGS5LQGIQ\SQLEXPRESS;Database=WellFoodDB;Trusted_Connection=True;TrustServerCertificate=True";
    public static string GetConnectionString()
    {
        return _connectionStr;
    }
}
