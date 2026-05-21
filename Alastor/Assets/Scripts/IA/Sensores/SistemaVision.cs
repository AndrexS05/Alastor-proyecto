using UnityEngine;

public class SistemaVIsion : MonoBehaviour
{
    [Header("Vision")]
    public float viewDistance = 10f;

    [Range(0, 360)]
    public float campoDeVision = 90f;

    public LayerMask Obstaculos;

    public Transform jugador;
    public void Update()
    {
        if(JugadorAlaVista())
        {
            Debug.Log("Lo veo");
        }
        else
        {
            Debug.Log("No lo veo");
        }
    }
    public bool JugadorAlaVista()
    {
        if (jugador == null)
            return false;
        Vector3 vectorDireccionJugador = jugador.position - transform.position;

        float distanciaJugador = vectorDireccionJugador.magnitude;

        if (distanciaJugador > viewDistance)
            return false;

        float angulo = Vector3.Angle(transform.forward, vectorDireccionJugador);

        if(angulo >campoDeVision/2)
            return false;

        if(Physics.Raycast(transform.position,vectorDireccionJugador.normalized,distanciaJugador,Obstaculos))
            return false;

        Debug.DrawRay(transform.position, vectorDireccionJugador , Color.green);

        return true;
    }
}
