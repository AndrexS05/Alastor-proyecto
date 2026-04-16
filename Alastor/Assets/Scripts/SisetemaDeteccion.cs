using UnityEngine;

public class DeteccionSistema : MonoBehaviour
{
    public Transform jugador;
    public Transform Enemigo;

    public float DistanciaAlerta = 10f;
    public float DistanciaPersecucion = 5f;

    public DeteccionEstados EstadoActual;

    public System.Action<DeteccionEstados> CambiarEstado;

    void Update()
    {
        float distancia = Vector3.Distance(jugador.position, Enemigo.position);
        DeteccionEstados nuevoEstado;

        if(distancia < DistanciaPersecucion )
        {
            nuevoEstado = DeteccionEstados.Persecucion;
            
        }
        else if( distancia < DistanciaAlerta )
        {
            nuevoEstado = DeteccionEstados.Alerta;
        }
        else
        {
            nuevoEstado = DeteccionEstados.Normal;
        }
        if (nuevoEstado != EstadoActual)
        {
            EstadoActual= nuevoEstado;
            CambiarEstado?.Invoke(EstadoActual);
        }
    }
}
