using System.Data.SQLite;

namespace Mynventory.Model
{
    public static class Baza
    {
        private static readonly string connectionString = "URI=file:Baza.db,version=3";

        internal static SQLiteConnection con = new SQLiteConnection(connectionString);

        internal static void OtvoriKonekciju()
        {
            con.Open();
        }

        internal static void ZatvoriKonekciju()
        {
            con.Close();
        }
    }
}
