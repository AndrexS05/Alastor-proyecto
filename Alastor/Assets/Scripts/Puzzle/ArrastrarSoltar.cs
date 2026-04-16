using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastrarSoltar : MonoBehaviour
{
    [Header("Objeto que se arrastra")]
    public GameObject llaveArrastrable;

    [Header("Posición correcta donde debe soltarse")]
    public GameObject posicionObjetivo;

    [Header("Distancia máxima para encajar")]
    public float distanciaEncaje = 50f;

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
            llaveArrastrable.transform.position = Input.mousePosition;
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
