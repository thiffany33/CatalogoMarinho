using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMarinho.Domain.Entities
{
    public class Classe
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        //Esses dois carinha vai ser uma coisa só, nas configurações vai anotar como fk.
        public int IdEspecie { get; set; }
        public virtual Especie Especie { get; set; }
        public virtual ICollection<Animal> Animais { get; set; }

        public Classe()
        {
            Animais = new HashSet<Animal>();
        }
    }
}
