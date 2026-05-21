using UnityEngine;

public class EstadoPatrulla : EstadoEnemigo
{
    private int indicePuntoActual;
    public EstadoPatrulla(AIEnemigo enemigo):base(enemigo)
    {

    }
    public override void Enter()
    {
        Debug.Log("Ahora Patrulla");
        MoverSiguientePunto();
    }
    public override void Update()
    {
        Debug.Log("Patrullando");
        if(!enemigo.agent.pathPending && enemigo.agent.remainingDistance<0.5f)
        {
            MoverSiguientePunto();
        }
    }
    public override void Exit()
    {
        Debug.Log("Salio de patrulla");
    }
    private void MoverSiguientePunto()
    {
        Debug.Log("Moviendo al punto");
        if (enemigo.puntosPatrulla.PuntosCount() == 0)
            return;
        Transform punto = enemigo.puntosPatrulla.GetPunto(indicePuntoActual);

        enemigo.agent.SetDestination(punto.position);

        indicePuntoActual++;

        if(indicePuntoActual >= enemigo.puntosPatrulla.PuntosCount())
        {
            indicePuntoActual = 0;
        }
    }
}
