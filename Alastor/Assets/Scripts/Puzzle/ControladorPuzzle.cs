using UnityEngine;

public class ControladorPuzzle : MonoBehaviour
{
    [Header("Pantallas del Puzzle (Canvas/Objetos)")]
    [Tooltip("El objeto 'Aviso' que dice que busque las llaves")]
    public GameObject canvasAviso;

    [Tooltip("El objeto 'AvisoPuerta' que dice que la puerta se abrió")]
    public GameObject canvasAvisoPuerta;

    private int llavesCorrectas = 0;

    private void Start()
    {
        // Al empezar el juego, el aviso inicial se prende y el de victoria se apaga
        if (canvasAviso != null) canvasAviso.SetActive(true);
        if (canvasAvisoPuerta != null) canvasAvisoPuerta.SetActive(false);
    }

    // Esto lo llamarán tus 3 sockets (BaseLlave1, BaseLlave2, BaseLlave3)
    public void LlaveColocada()
    {
        llavesCorrectas++;
        Debug.Log($"Llave colocada con éxito. Total: {llavesCorrectas}/3");

        if (llavesCorrectas >= 3)
        {
            ResolverPuzzle();
        }
    }

    // Esto lo llamarán si el jugador retira una llave que estaba bien
    public void LlaveRetirada()
    {
        llavesCorrectas--;
        if (llavesCorrectas < 0) llavesCorrectas = 0;

        // Si ya habían ganado pero sacan una llave, vuelve a pedir las llaves
        if (llavesCorrectas < 3)
        {
            if (canvasAviso != null) canvasAviso.SetActive(true);
            if (canvasAvisoPuerta != null) canvasAvisoPuerta.SetActive(false);
        }
    }

    private void ResolverPuzzle()
    {
        Debug.Log("¡Puzzle Completado! Puerta de recepción abierta.");

        // Apagamos las instrucciones y encendemos el aviso de la puerta
        if (canvasAviso != null) canvasAviso.SetActive(false);
        if (canvasAvisoPuerta != null) canvasAvisoPuerta.SetActive(true);
    }
}
