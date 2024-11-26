using System;
using System.Collections.Generic;

namespace Pokemon_Like.Model
{
    public partial class Cour
    {
        public int CoursId { get; set; }

        public string NomCours { get; set; } = null!;

        public string? Description { get; set; }

        public string Enseignant { get; set; } = null!;

        public virtual ICollection<Inscription> Inscriptions { get; set; } = new List<Inscription>();
    }
}
