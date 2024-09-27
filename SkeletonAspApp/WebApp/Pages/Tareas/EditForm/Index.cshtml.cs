using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Model.Entities;
using Service.Servicios;

namespace WebApp.Pages.Tareas.EditForm
{
    public class IndexModel : PageModel
    {
        private readonly ITareaServicio _tareaServicio;
        [BindProperty]
        public Tarea Tarea { get; set; }

        public IndexModel(ITareaServicio tareaServicio)
        {
            _tareaServicio = tareaServicio;
        }

        public IActionResult OnPostCrear(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                tarea.FechaCreacion = DateTime.Now;
                _tareaServicio.AgregarTarea(tarea);
                return new JsonResult(new { succcess = true, redirectUrl = Url.Page("/Tareas") });

            }
            return BadRequest(ModelState);
        }

        public void OnGet(int id)
        {
            Tarea = _tareaServicio.BuscarTareaId(id);
        }

        public IActionResult OnGetEditar(int id)
        {
            var tarea = _tareaServicio.BuscarTareaId(id);
            if (tarea == null)
            {
                return NotFound(); // Devuelve un 404 si no encuentra la tarea
            }
            return new JsonResult(new { success = true }); // Retorna un JSON como respuesta
        }

        public IActionResult OnGetEliminar(int id)
        {
            var tarea = _tareaServicio.BuscarTareaId(id);
            if (tarea == null)
            {
                return NotFound(); // Devuelve un 404 si no encuentra la tarea
            }

            _tareaServicio.EliminarTarea(tarea); // Elimina la tarea
            return new JsonResult(new { success = true }); // Retorna un JSON como respuesta
        }

    }
}
