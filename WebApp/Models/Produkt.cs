using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class Produkt
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz podać nazwe produkt")]
    public string Name { get; set; }

    [Required] public int Price { get; set; }
    
    [MinLength(length:5, ErrorMessage ="Producent musi być podany!")]
    [Required(ErrorMessage ="Proszę wpisz producenta!")]
    public string Producent { get; set; }
    
    [DataType(DataType.Date)] public DateTime Produktdate { get; set; }
    
    [MinLength(length:5, ErrorMessage ="Wiadomość musi mieć co najmniej 5 znaków!")]
    [Required(ErrorMessage ="Proszę wpisz wiadomość!")]
    public string Description { get; set; }
    
}