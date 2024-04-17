
using System.Text.Json.Serialization;

namespace Consumir_WebApi2_Produtos.Models
{

    public class Produto
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("Descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("Categoria")]
        public string Categoria { get; set; }

    }
}



