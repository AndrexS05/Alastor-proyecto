using UnityEngine;
using UnityEngine.InputSystem;

public class ArrastrarSoltar : MonoBehaviour
{
    public GameObject posicionObjetivo;
    public float distanciaEncaje = 40f;

    [HideInInspector] public bool bloqueado = false;

    private Vector3 posicionInicial;
    private PuzzleManager puzzleManager;

    void Start()
    {
        posicionInicial = transform.position;
        puzzleManager = FindObjectOfType<PuzzleManager>();
    }

    public void ArrastrarObjeto()
    {
        if (!bloqueado)
        {
            transform.position = Mouse.current.position.ReadValue();
        }
    }

    public void SoltarObjeto()
    {
        float distancia = Vector3.Distance(
            transform.position,
            posicionObjetivo.transform.position
        );

        if (distancia < distanciaEncaje)
        {
            puzzleManager.ValidarLlave(this);
        }
        else
        {
            transform.position = posicionInicial;
        }
    }

    public void EncajarLlave()
    {
        bloqueado = true;
        transform.position = posicionObjetivo.transform.position;
    }

    public void RegresarInicio()
    {
        transform.position = posicionInicial;
    }
}