using UnityEngine;

public class ControladorLuces : MonoBehaviour
{
    // Arrastra aquí todas las luces que quieras controlar
    public Light[] luces; 

    // Esta función SOLAMENTE ENCIENDE las luces
    public void EncenderLuces()
    {
        foreach (Light luz in luces)
        {
            if (luz != null)
            {
                luz.enabled = true; 
            }
        }
    }

    // Esta función SOLAMENTE APAGA las luces
    public void ApagarLuces()
    {
        foreach (Light luz in luces)
        {
            if (luz != null)
            {
                luz.enabled = false; 
            }
        }
    }
}