using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMarinho.Domain.Entities
{
    public class Animal: BaseEntity
    {
        public int IdClasse { get; set; } //fk de ID da classe class 
        public string Sexo { get; set; }
        public string Migracao { get; set; }
        public string Gestacao { get; set; }
        public string TipoGestacao { get; set; }
        public Perigo Tipo { get; set; }

        public virtual Classe Classe { get; set; } //A parte 1 do n. 
    }
}
