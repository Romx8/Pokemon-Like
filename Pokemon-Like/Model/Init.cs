﻿using System;
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
            MessageBox.Show("Database initialized with 10 Pokémon!");

            if (!_context.Monsters.Any())
                {
                    var monsters = new List<Monster>
                    {
                        new Monster { Name = "Bulbasaur", Health = 45 },
                        new Monster { Name = "Charmander", Health = 39 },
                        new Monster { Name = "Squirtle", Health = 44 },
                        new Monster { Name = "Pikachu", Health = 35 },
                        new Monster { Name = "Jigglypuff", Health = 115 },
                        new Monster { Name = "Meowth", Health = 40 },
                        new Monster { Name = "Psyduck", Health = 50 },
                        new Monster { Name = "Machop", Health = 70 },
                        new Monster { Name = "Geodude", Health = 40 },
                        new Monster { Name = "Gastly", Health = 30 }
                    };

            _context.Monsters.AddRange(monsters);
            _context.SaveChanges();
            }
        }
}
}
