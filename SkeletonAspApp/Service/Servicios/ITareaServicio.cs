using Model.Entities;

namespace Service.Servicios
{
    public interface ITareaServicio
    {
        IEnumerable<Tarea> ListarTareas();
        IEnumerable<Tarea> ListarTareasCompletas();
        void AgregarTarea(Tarea task);
        void ActualizarTarea(Tarea task);
        void EliminarTarea(Tarea task);
        Tarea BuscarTareaId(int id);
    }
}
