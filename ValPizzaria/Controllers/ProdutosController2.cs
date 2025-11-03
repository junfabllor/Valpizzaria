using Microsoft.AspNetCore.Mvc;
using ValPizzaria.Models;
using System.Collections.Generic;

namespace ValPizzaria.Controllers
{
    public class ProdutosController2 : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                // TRADICIONAIS
                new Produto { Id = 1, Nome = "Calabresa", Categoria = "Tradicional", Preco = 40.00m, Imagem =  "/img/pizza.png" },
                new Produto { Id = 2, Nome = "Frango com Catupiry", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 3, Nome = "Frango Especial", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 4, Nome = "Marguerita", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 5, Nome = "Moda da Casa", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 6, Nome = "Napolitana", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 7, Nome = "Fascinação", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 8, Nome = "Baiana", Categoria = "Tradicional", Preco = 40.00m, Imagem = "/img/pizza.png" },

                // GOURMET
                new Produto { Id = 9, Nome = "Frango com Palmito", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 10, Nome = "Frango com Bacon", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 11, Nome = "Bacon", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 12, Nome = "Portuguesa", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 13, Nome = "Especial", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 14, Nome = "Mista", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 15, Nome = "4 Queijos", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 16, Nome = "Calabresa Especial", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 17, Nome = "Brasileira", Categoria = "Gourmet", Preco = 40.00m, Imagem = "/img/pizza.png" },

                // PREMIUM
                new Produto { Id = 18, Nome = "Bolonhesa", Categoria = "Premium", Preco = 45.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 19, Nome = "Fricassê", Categoria = "Premium", Preco = 50.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 20, Nome = "Escondidinho de Carne de Sol", Categoria = "Premium", Preco = 50.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 21, Nome = "Strogonoff de Frango", Categoria = "Premium", Preco = 50.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 22, Nome = "Strogonoff de Carne", Categoria = "Premium", Preco = 50.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 23, Nome = "Cangaceiro", Categoria = "Premium", Preco = 50.00m, Imagem = "/img/pizza.png" },
                new Produto { Id = 24, Nome = "Considerada", Categoria = "Premium", Preco = 60.00m, Imagem = "/img/pizza.png" }
            };

            return View(produtos);
        }
    }
}
