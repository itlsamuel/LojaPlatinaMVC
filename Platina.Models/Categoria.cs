using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Platina.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Mostrar Pedido")]
        public int MostrarPedido { get; set; }
        public DateTime CriarData { get; set; } = DateTime.Now;
    }
}
 