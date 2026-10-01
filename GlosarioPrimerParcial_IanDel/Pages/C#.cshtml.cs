using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GlosarioPrimerParcial_IanDel.Model;

namespace GlosarioPrimerParcial_IanDel.Pages
{
    public class CSharpModel : PageModel
    {
        public static List<Termino> GlosarioCsharp = new List<Termino>();


        public void OnGet()
        {
            if (GlosarioCsharp.Count == 0)
            {
                GlosarioCsharp.Add(new Model.Termino { Palabra = "Clase", Definicion = "Una clase es una plantilla o un modelo que define las propiedades y comportamientos de un objeto en la programación orientada a objetos." });
                GlosarioCsharp.Add(new Model.Termino { Palabra = "Constructor", Definicion = "Un constructor es un método especial de una clase que se utiliza para inicializar objetos de esa clase." });
                GlosarioCsharp.Add(new Model.Termino { Palabra = "C#", Definicion = "C# es un lenguaje de programación moderno, orientado a objetos y desarrollado por Microsoft, utilizado principalmente para el desarrollo de aplicaciones en la plataforma .NET." });
            }
        }

        public IActionResult OnPost(string nuevapalabra, string nuevadefinicion)
        {
            if (!string.IsNullOrEmpty(nuevapalabra) && !string.IsNullOrEmpty(nuevadefinicion))
            {
                GlosarioCsharp.Add(new Termino 
                { 
                    Palabra = nuevapalabra, Definicion = nuevadefinicion 
                });
            }
            return RedirectToPage();
        }
    }
}
