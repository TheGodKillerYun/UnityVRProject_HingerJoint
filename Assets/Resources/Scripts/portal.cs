 using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GestorProgresoPortal : MonoBehaviour
{
    [Header("Configuración")]
    public GameObject objetoARevelar; // El portal o salida
    public int objetosNecesarios = 3;
    
    private int objetosActuales = 0;

    void Start()
    {
        // Asegurarnos de que el portal empiece invisible
        if (objetoARevelar != null)
            objetoARevelar.SetActive(false);
    }

    // Esta función la llamaremos desde el evento 'Select Entered' del Socket
    public void ObjetoColocado()
    {
        objetosActuales++;
        VerificarProgreso();
    }

    // Esta función la llamaremos desde el evento 'Select Exited' del Socket
    public void ObjetoQuitado()
    {
        objetosActuales--;
        VerificarProgreso();
    }

    private void VerificarProgreso()
    {
        if (objetosActuales >= objetosNecesarios)
        {
            RevelarSalida();
        }
        else
        {
            // Opcional: Si quitan un objeto, el portal se vuelve a ocultar
            objetoARevelar.SetActive(false);
        }
    }

    private void RevelarSalida()
    {
        if (objetoARevelar != null)
        {
            objetoARevelar.SetActive(true);
            Debug.Log("¡Portal activado! Has escapado de la dimensión de bolsillo.");
        }
    }
}