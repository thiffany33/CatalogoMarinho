using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoMarinho.Domain.Entities
{
    public class Especie
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Classe> Classes { get; set; } //Uma especie possui uma lista de classes 1 para n. Esse é o lado do N

        public Especie()
        {
            Classes = new HashSet<Classe>();
        }
    }
}
