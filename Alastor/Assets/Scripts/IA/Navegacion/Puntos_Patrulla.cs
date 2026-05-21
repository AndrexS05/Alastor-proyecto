using UnityEngine;

public class PuntosPatrulla : MonoBehaviour
{
    public Transform[] puntosPatrulla;

    public Transform GetPunto(int index)
    {
        return puntosPatrulla[index];
    }
    public int PuntosCount()
    {
        return puntosPatrulla.Length;
    }
}
