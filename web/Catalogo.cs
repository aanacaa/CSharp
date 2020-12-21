using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivros()
        {


            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu", 21.55m));
            livros.Add(new Livro("002", "Bom 2", 25.58m));
            livros.Add(new Livro("003", "Quem 3", 71.99m));

            return livros;
        }
    }
}
