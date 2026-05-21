using UnityEngine;

public class ControlEstados 
{
    public EstadoEnemigo EstadoActual;

    public void CambiarEstado(EstadoEnemigo NuevoEstado)
    {
        EstadoActual?.Exit();

        EstadoActual = NuevoEstado;

        EstadoActual.Enter();
    }
    public void Update()
    {
        EstadoActual?.Update();
    }
}
