using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.Entities;
using Service.Servicios;

namespace WebApp.Pages.Tareas
{
    public class IndexModel : PageModel
    {
        private readonly ITareaServicio _tareaServicio;

        [BindProperty]
        public IEnumerable<Tarea> Tareas { get; set; }

        public IndexModel(ITareaServicio tareaServicio)
        {
            _tareaServicio = tareaServicio;
        }

        public IActionResult OnGetTareas()
        {
            var tareas = _tareaServicio.ListarTareas();
            return new JsonResult(tareas);
        }
    }
}
