using UnityEngine;
using UnityEngine.AI;

public class AIEnemigo : MonoBehaviour
{
   
    public NavMeshAgent agent;
    public PuntosPatrulla puntosPatrulla;
    private ControlEstados controlEstados;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        controlEstados = new ControlEstados();
        controlEstados.CambiarEstado(new EstadoPatrulla(this));
    }
    private void Update()
    {
        controlEstados.Update();
    }
}
