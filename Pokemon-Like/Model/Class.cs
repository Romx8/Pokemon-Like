using System;
using System.Collections.Generic;

namespace Pokemon_Like.Model
{
    public partial class Class
    {
        public int ClasseId { get; set; }

        public string NomClasse { get; set; } = null!;

        public string Niveau { get; set; } = null!;

        public virtual ICollection<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
    }
}
