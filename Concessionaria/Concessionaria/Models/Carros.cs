using System.ComponentModel.DataAnnotations;
namespace Concessionaria.View.Models
{
    public class Carros
    {
        [Required(ErrorMessage = "Informe a marca do veículo")]
        [Display(Name = "Marca")]
        public string marca { get; set; }

        [Required(ErrorMessage = "Informe a modelo do veículo")]
        [Display(Name = "Modelo")]
        public string modelo { get; set; }

        [Required(ErrorMessage = "Informe o ano de fabricação do veículo")]
        [Display(Name = "Ano de Fabricação")]
        [StringLength(maximumLength:4, MinimumLength = 4, ErrorMessage = "O ano de fabricação deve ter 4 digítos!")]
        public string anoFabricacao { get; set; }

        [Required(ErrorMessage = "Informe valor do veículo")]
        [Display(Name = "Valor do veículo")]
        public string valor { get; set; }

    }
}
