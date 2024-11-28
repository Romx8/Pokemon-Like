using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Pokemon_Like.MVVM.ViewModel;

namespace Pokemon_Like.Model
{
    public class LogicBDD
    {
        private readonly ExerciceMonsterContext _context;

        public LogicBDD(ExerciceMonsterContext context) 
        {
            _context = context;
        }

        public bool Login(string username, string password)
        {
            var hashedPassword = HashPassword(password);
            var user = _context.Logins.FirstOrDefault(l => l.Username == username && l.PasswordHash == hashedPassword);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password");
                return false;
            }
            return true;
        }

        public bool Register(string username, string password)
        {
            if (_context.Logins.Any(l => l.Username == username))
            {
                MessageBox.Show("Username already exists");
                return false;
            }

            var hashedPassword = HashPassword(password);

            var newUser = new Login
            {
                Username = username,
                PasswordHash = hashedPassword
            };

            _context.Logins.Add(newUser);
            _context.SaveChanges();
            return true;
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

    }
}
