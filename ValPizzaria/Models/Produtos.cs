namespace ValPizzaria.Models
{
    public class Produtos
    {
        
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Categoria { get; set; } // Ex: "Pizza", "Refrigerante", etc.
            public decimal Preco { get; set; }
            public string Imagem { get; set; } // Caminho da imagem
        
    }

}

