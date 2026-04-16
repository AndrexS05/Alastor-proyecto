using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [Header("Llave correcta")]
    public ArrastrarSoltar llaveCorrecta;

    [Header("Temporizador")]
    public float tiempoRestante = 12f;
    public float penalizacionError = 2f;

    [Header("UI")]
    public GameObject panelGameOver;

    private bool puzzleResuelto = false;

    void Update()
    {
        if (!puzzleResuelto)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante <= 0)
            {
                tiempoRestante = 0;
                PerderPuzzle();
            }
        }
    }

    public void ValidarLlave(ArrastrarSoltar llaveIntentada)
    {
        if (llaveIntentada == llaveCorrecta)
        {
            puzzleResuelto = true;
            llaveIntentada.EncajarLlave();

            Debug.Log("Puzzle resuelto.");
        }
        else
        {
            llaveIntentada.RegresarInicio();

            tiempoRestante -= penalizacionError;

            Debug.Log("Llave incorrecta. -2 segundos.");
        }
    }

    void PerderPuzzle()
    {
        Debug.Log("Tiempo agotado. Te atraparon.");

        panelGameOver.SetActive(true);
    }
}