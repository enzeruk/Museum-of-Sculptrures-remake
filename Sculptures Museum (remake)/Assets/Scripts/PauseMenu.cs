using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pause;
    public GameObject options;
    
    // SFX
    AudioSource _audio;
    public AudioClip startSFX;
    public AudioClip exitSFX;

    void Start()
    {
        // pauseSceneCheck = gameObject.AddComponent<ScenesManager>();
        _audio = GetComponent<AudioSource>();
        if (_audio == null)
        {
            // If AudioSource is missing
            Debug.LogWarning("AudioSource component is missing.");
            // Add the AudioSource component dynamically
            _audio = gameObject.AddComponent<AudioSource>();
        }
    }

    public void MainMenuButton()
    {
        OnClickSFX(startSFX);

        // Has to wait to load the game scene, so that the sfx can be played
        StartCoroutine(MainMenu());
    }

    public void Resume()
    {
        OnClickSFX(exitSFX);
        options.SetActive(false);
        pause.SetActive(false);
        SceneManager.UnloadSceneAsync ("PauseMenu");
        ScenesManager.pauseSceneLoaded = false;

        // Lock the cursor 
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    IEnumerator MainMenu()
    {
        yield return new WaitForSeconds(0.35f);
        SceneManager.LoadScene("MainMenu");
    }

    public void OptionsMenu()
    {
        OnClickSFX(startSFX);

        // Has to wait to switch menus, so that the sfx can be played
        StartCoroutine(SwitchMenu());
    }

    IEnumerator SwitchMenu()
    {
        yield return new WaitForSeconds(0.25f);

        pause.SetActive(false);
        options.SetActive(true);
    }

    public void ExitGame() 
    {
        OnClickSFX(exitSFX);
        Application.Quit();
    }

    public void OnClickSFX(AudioClip clip)
    {
        _audio.PlayOneShot(clip);
    }
}
