using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SistemaAudioJugador : MonoBehaviour
{
    public DeteccionSistema deteccion;
    public EventReference hearheartbeat;
    public EventReference viento;

    private EventInstance instanceLatidos;
    private EventInstance instanceViento;

    void Start()
    {
        instanceLatidos = RuntimeManager.CreateInstance(hearheartbeat);
        instanceLatidos.start();
        instanceViento = RuntimeManager.CreateInstance(viento);
        instanceViento.start();

        if (deteccion != null)
        {
            deteccion.CambiarEstado += CambiarIntensidad;
        }
        CambiarIntensidad(deteccion.EstadoActual);
    }
    
    void CambiarIntensidad(DeteccionEstados Estado)
    {
        float intensidad = 0f;

        switch(Estado)
        {
            case DeteccionEstados.Normal:
                intensidad = 0.1f;
                break;
            case DeteccionEstados.Alerta:
                intensidad = 0.6f;
                break;
            case DeteccionEstados.Persecucion:
                intensidad = 1f;
                break;

        }
        instanceLatidos.setParameterByName("Intensidad", intensidad);
        instanceViento.setParameterByName("Intensidad", intensidad);
    }

    private void OnDestroy()
    {
        if(deteccion !=null)
        {
            deteccion.CambiarEstado -= CambiarIntensidad;
        }
        instanceLatidos.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        instanceLatidos.release();
    }
}
