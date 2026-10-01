using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GlosarioPrimerParcial_IanDel.Model;

namespace GlosarioPrimerParcial_IanDel.Pages
{
    public class HTMLModel : PageModel
    {

        public static List<Termino> GlosarioHTML = new List<Termino>();
        
        public void OnGet()
        {
            
         new Termino { Palabra = "Etiqueta", Definicion = "Una etiqueta es un elemento de HTML que se utiliza para definir la estructura y el contenido de una página web." };
            new Termino { Palabra = "Atributo", Definicion = "Un atributo es una característica adicional que se puede agregar a una etiqueta HTML para modificar su comportamiento o apariencia." };
            new Termino { Palabra = "Elemento", Definicion = "Un elemento es una unidad básica de HTML que consiste en una etiqueta de apertura, un contenido y una etiqueta de cierre." };
        
        }

        public IActionResult OnPost(string nuevapalabra, string nuevadefinicion)
        {
            if (!string.IsNullOrEmpty(nuevapalabra) && !string.IsNullOrEmpty(nuevadefinicion))
            {
                GlosarioHTML.Add(new Termino
                {
                    Palabra = nuevapalabra,
                    Definicion = nuevadefinicion
                });
            }
            return RedirectToPage();
        }
    }
}
