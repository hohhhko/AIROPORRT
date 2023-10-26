using System;
using System.Windows.Forms;

namespace Аэропрот
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAutoriztion());
        }

    }
    static class DataBase
    {
        public static string ConnetctionString = @"Data Source= BASE.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    #region table
    static class Table_Reisi
    {
        public static string main = "Reisi";
        public static string ID = "ID";
        public static string NamePilot = "NamePilot";
        public static string Time = "Time";
        public static string Place = "Place";
        public static string NumberTicet = "NumberTicet";
    }
    static class Table_Tablo
    {
        public static string main = "Tablo";
        public static string ID = "ID";
        public static string FullNameUser = "FullNameUser";
        public static string Place = "Place";
        public static string Time = "Time";
        public static string DateReisa = "DateReisa";
        public static string NumberTicet = "NumberTicet";
    }
    static class Table_Users
    {
        public static string main = "Users";
        public static string ID = "ID";
        public static string Name = "Name";
        public static string Suranme = "Suranme";
        public static string Age = "Age";
        public static string Pasport = "Pasport";
    }
    static class Table_sqlite_sequence
    {
        public static string main = "sqlite_sequence";
        public static string name = "name";
        public static string seq = "seq";
    }

    #endregion
}
