using UnityEngine;
using UnityEngine.Video; 
public class ControlTV : MonoBehaviour
{
    [Header("Arrastra aquí el objeto que tiene el Video Player")]
    public VideoPlayer reproductorDeVideo;

    public void PresionarBotonPoder()
    {
        if (reproductorDeVideo != null)
        {
            if (reproductorDeVideo.isPlaying)
            {
                reproductorDeVideo.Pause();
            }
            else
            {
                reproductorDeVideo.Play();
            }
        }
    }
}