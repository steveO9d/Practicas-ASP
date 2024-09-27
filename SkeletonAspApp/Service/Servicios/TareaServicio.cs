using Data.Repositories;
using Model.Entities;


namespace Service.Servicios
{
    public class TareaServicio : ITareaServicio
    {
        private readonly ITareaRepositorio _taskRepository;

        public TareaServicio(ITareaRepositorio taskRepository)
        {
            _taskRepository = taskRepository;
        }

        IEnumerable<Tarea> ITareaServicio.ListarTareas()
        {
            return _taskRepository.ListarTareas();
        }

        IEnumerable<Tarea> ITareaServicio.ListarTareasCompletas()
        {
            return _taskRepository.ListarTareasCompletas();
        }

        void ITareaServicio.AgregarTarea(Tarea task)
        {
            _taskRepository.AgregarTarea(task);
        }

        void ITareaServicio.ActualizarTarea(Tarea task)
        {
            _taskRepository.ActualizarTarea(task);
        }

        void ITareaServicio.EliminarTarea(Tarea task)
        {
            _taskRepository.EliminarTarea(task);
        }

        Tarea ITareaServicio.BuscarTareaId(int id)
        {
            return _taskRepository.buscarTareaId(id);
        }
    }
}
