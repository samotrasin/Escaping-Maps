using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------- Audio Sources -------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("------- Audio Clips -------")]
    public AudioClip backgroundMusic;
    public AudioClip death;
    public AudioClip hover;
    public AudioClip click;

    private static AudioManager instance;

    private void Awake()
    {
        // Singleton pattern - only one AudioManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep this object across scenes
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate
        }
    }

    private void Start()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlayHover()
    {
        PlaySFX(hover);
    }

    public void PlayClick()
    {
        PlaySFX(click);
    }
    public void PlayDeath()
    {
        PlaySFX(death);
    }
}
