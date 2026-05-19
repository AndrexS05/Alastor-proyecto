using UnityEngine;

public class LinternaVR : MonoBehaviour
{
    [Header("Configuración")]
    [Tooltip("Arrastra aquí tu objeto 'Spot Light Linterna'")]
    public Light luzLinterna;

    private bool estaEncendida = false;

    private void Start()
    {
        // Apagamos la luz al inicio del juego
        if (luzLinterna != null)
        {
            luzLinterna.enabled = false;
        }
    }

    // Esta función se activará al apretar el gatillo
    public void AlternarLinterna()
    {
        if (luzLinterna == null) return;

        estaEncendida = !estaEncendida;
        luzLinterna.enabled = estaEncendida;
    }

}