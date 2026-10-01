using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GlosarioPrimerParcial_IanDel.Model;

namespace GlosarioPrimerParcial_IanDel.Pages
{
    public class CSSModel : PageModel
    {
        public static List<Termino> GlosarioCSS = new List<Termino>();


        public void OnGet()
        {
            if (GlosarioCSS.Count == 0)
            {
                GlosarioCSS.Add(new Model.Termino { Palabra = "Selector", Definicion = "Un selector es una parte de una regla CSS que se utiliza para seleccionar los elementos HTML a los que se aplicarán los estilos." });
                GlosarioCSS.Add(new Model.Termino { Palabra = "Propiedad", Definicion = "Una propiedad es un atributo de estilo que se aplica a un elemento HTML seleccionado mediante un selector." });
                GlosarioCSS.Add(new Model.Termino { Palabra = "Valor", Definicion = "Un valor es el valor que se asigna a una propiedad de estilo para definir cómo se verá un elemento HTML." });
            }
        }

        public IActionResult OnPost(string nuevapalabra, string nuevadefinicion)
        {
            if (!string.IsNullOrEmpty(nuevapalabra) && !string.IsNullOrEmpty(nuevadefinicion))
            {
                GlosarioCSS.Add(new Termino
                {
                    Palabra = nuevapalabra,
                    Definicion = nuevadefinicion
                });
            }
            return RedirectToPage();
        }
    }
}
