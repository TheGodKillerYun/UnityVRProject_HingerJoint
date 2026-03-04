using UnityEngine;
using System.Collections;
using TMPro; // Asegúrate de tener instalado TextMeshPro

public class FeedbackVisualSocket : MonoBehaviour
{
    [Header("Referencias de UI")]
    [Tooltip("El Canvas o Panel que contiene el mensaje de éxito")]
    public GameObject canvasMensaje;

    [Header("Configuración")]
    [Tooltip("Tiempo que el mensaje permanecerá visible en VR")]
    public float duracionVisible = 2.0f;

    private Coroutine rutinaActiva;

    void Awake()
    {
        // Nos aseguramos de que el mensaje empiece oculto
        if (canvasMensaje != null)
        {
            canvasMensaje.SetActive(false);
        }
    }

    // Esta función la llamaremos desde el evento OnSelectEntered del Socket
    public void MostrarExito()
    {
        if (canvasMensaje != null)
        {
            if (rutinaActiva != null)
            {
                StopCoroutine(rutinaActiva);
            }
            rutinaActiva = StartCoroutine(SecuenciaMensaje());
        }
    }

    private IEnumerator SecuenciaMensaje()
    {
        canvasMensaje.SetActive(true);
        yield return new WaitForSeconds(duracionVisible);
        canvasMensaje.SetActive(false);
        rutinaActiva = null;
    }
}