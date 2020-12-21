using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App.Logica
{
    public class LivrosController :Controller
    {
        public IOrderedEnumerable<Livro> Livros { get; set; }

        //private static string CarregaArquivoHTML(string nomeArquivo)
        //{
        //    var nomeCompletoArquivo = $"HTML/{nomeArquivo}.html";
        //    using (var arquivo = File.OpenText(nomeCompletoArquivo))
        //    {
        //        return arquivo.ReadToEnd();
        //    }
        //}


       
        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }
        public string  Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
        public string Teste()
        {
           return "A nova funcionalidade foi implementada!";

        }

    }
}
