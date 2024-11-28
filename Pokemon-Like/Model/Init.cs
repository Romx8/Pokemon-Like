using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Pokemon_Like.Model
{
    public class Init
    {
        ExerciceMonsterContext? _context;

        public Init() 
        {
            InitDB();
        }

        public void InitDB()
        {
            _context = new ExerciceMonsterContext();
            _context.Database.EnsureCreated();
            _context.Logins.Add(new Login { Username = "admin", PasswordHash = LogicBDD.HashPassword("admin") });
            _context.SaveChanges();
        }
    }
}
