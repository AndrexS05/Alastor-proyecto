using UnityEngine;

public class EstadoAlerta : EstadoEnemigo
{
    public EstadoAlerta(AIEnemigo enemigo): base(enemigo)
    {

    }
    public override void Enter()
    {
        Debug.Log("Ahora Alerta");
    }
    public override void Update()
    {
        Debug.Log("Alerta");
    }
    public override void Exit()
    {
        Debug.Log("Salio de Alerta");
    }
}
