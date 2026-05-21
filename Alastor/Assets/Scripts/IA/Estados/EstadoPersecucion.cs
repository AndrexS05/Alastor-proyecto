using UnityEngine;

public class EstadoPersecucion : EstadoEnemigo
{
    public EstadoPersecucion(AIEnemigo enemigo) : base(enemigo)
    {

    }
    public override void Enter()
    {
        Debug.Log("Ahora Persecucion");
    }
    public override void Update()
    {
        Debug.Log("Persiguiendo");
    }
    public override void Exit()
    {
        Debug.Log("Salio de Persecucion");
    }
}
