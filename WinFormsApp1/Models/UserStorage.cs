using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public static class UserStorage
    {
        private static string FilePath = "users.txt";
        private static string LibrariesFolder = "libraries";

        public static string GetLibraryFilePath(string username)
        {
            if (!Directory.Exists(LibrariesFolder))
                Directory.CreateDirectory(LibrariesFolder);

            return Path.Combine(LibrariesFolder, $"{username}_library.txt");
        }
        public static void SaveUser(User user)
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(user.ToString());
            }
        }
        public static List<User> LoadUsers()
        {
            if (!File.Exists(FilePath)) return new List<User>();

            return File.ReadAllLines(FilePath).Select(User.FromString).ToList();
        }

        public static bool UserExists(string username)
        {
            return LoadUsers().Any(u => u.Username == username);
        }

        public static bool ValidateLogin(string username, string password)
        {
            return LoadUsers().Any(u => u.Username == username && u.Password == password);
        }
    }
}
