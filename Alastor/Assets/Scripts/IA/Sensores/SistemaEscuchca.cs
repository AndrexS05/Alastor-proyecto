using UnityEngine;

public class SistemaEscuchca : MonoBehaviour
{
    [Header("Escucha")]
    public float rangoEscucha = 10f;

    public Vector3 ultimaPosicionEscuchada;

    public bool sonidoEscuchado;

    public void SonidoEscuchado(Vector3 posicionSonido, float intensidad)
    {
        float distancia = Vector3.Distance(transform.position, posicionSonido);

        float rangoFinal = rangoEscucha * intensidad;

        if(distancia<=rangoFinal)
        {
            sonidoEscuchado = true;
            ultimaPosicionEscuchada = posicionSonido;
            Debug.Log("Sonido escuchado");
        }
    }
    public void reiniciarEscucha()
    {
        sonidoEscuchado=false;
    }
}
