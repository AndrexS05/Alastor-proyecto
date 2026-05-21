using UnityEngine;

public class EsadoBusqueda : EstadoEnemigo
{
    public EsadoBusqueda(AIEnemigo enemigo) : base(enemigo)
    {

    }
    public override void Enter()
    {
        Debug.Log("Ahora Busqueda");
    }
    public override void Update()
    {
        Debug.Log("Buscando");
    }
    public override void Exit()
    {
        Debug.Log("Salio de Busqueda");
    }
}
