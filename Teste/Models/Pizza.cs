using System;
namespace Teste.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public float Preco { get; set; }

        public Pizza(String Nome, float Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}
