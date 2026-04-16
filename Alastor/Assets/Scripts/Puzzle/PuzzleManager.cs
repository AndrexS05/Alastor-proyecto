using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [Header("Llave correcta del puzzle")]
    public ArrastrarSoltar llaveCorrecta;

    public void ValidarLlave(ArrastrarSoltar llaveIntentada)
    {
        if (llaveIntentada == llaveCorrecta)
        {
            llaveIntentada.EncajarLlave();

            Debug.Log("Llave correcta. Puzzle resuelto.");

            // Aquí luego puedes abrir puerta
        }
        else
        {
            llaveIntentada.RegresarInicio();

            Debug.Log("Llave incorrecta.");
        }
    }
}