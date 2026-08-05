using UnityEngine;

public class SFXScript : MonoBehaviour
{
    public AudioSource SFXSource;
    public AudioClip[] audioClips;

    public void PlaySFX(int ix)
    {
        if (SFXSource.isPlaying)
            SFXSource.Stop();

        SFXSource.PlayOneShot(audioClips[ix]);

    }

}
