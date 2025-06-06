using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"{Username}|{Password}";
        }
        public static User FromString(string line)
        {
            var parts = line.Split("|");
            return new User { Username = parts[0], Password = parts[1] };
        }
    }
}
