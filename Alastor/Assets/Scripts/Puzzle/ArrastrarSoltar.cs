using UnityEngine;
using UnityEngine.InputSystem;

public class ArrastrarSoltar : MonoBehaviour
{
    [Header("Objeto a arrastrar")]
    public GameObject llaveArrastrable;

    [Header("Posición donde soltar")]
    public GameObject posicionObjetivo;

    [Header("Distancia máxima para encajar")]
    public float distanciaEncaje = 40f;

    [Header("Estado del objeto")]
    public bool bloqueado = false;

    private Vector3 posicionInicial;

    void Start()
    {
        posicionInicial = llaveArrastrable.transform.position;
    }

    public void ArrastrarObjeto()
    {
        if (!bloqueado)
        {
            llaveArrastrable.transform.position = Mouse.current.position.ReadValue();
        }
    }

    public void SoltarObjeto()
    {
        float distancia = Vector3.Distance(
            llaveArrastrable.transform.position,
            posicionObjetivo.transform.position
        );

        if (distancia < distanciaEncaje)
        {
            bloqueado = true;
            llaveArrastrable.transform.position = posicionObjetivo.transform.position;
        }
        else
        {
            llaveArrastrable.transform.position = posicionInicial;
        }
    }
}