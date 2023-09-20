using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class ScenesManager : MonoBehaviour
{
    [SerializeField] public GameObject player; 

    public bool languageSceneLoaded;
    public bool sceneLoaded;
    public bool formatSceneLoaded;
    public static bool pauseSceneLoaded;
    
    void Start()
    {
        languageSceneLoaded = false;
        sceneLoaded = false;
        formatSceneLoaded = false;
        pauseSceneLoaded = false;
    }

    void Update()
    {
        Debug.Log("pauseSceneLoaded = " + pauseSceneLoaded);
        if(Input.GetKeyUp(KeyCode.Escape) && pauseSceneLoaded == false)
        {
            SceneManager.LoadScene ("PauseMenu", LoadSceneMode.Additive);
            pauseSceneLoaded = true;
            
            // Unlock the cursor
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void SelectLanguageToLoad()
    {
        SceneManager.LoadScene ("SelectLanguage", LoadSceneMode.Additive);
        languageSceneLoaded = true;

        // Unlock the cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void QuizToLoad() 
    {
        if (languageSceneLoaded == true)
        {
            SceneManager.UnloadSceneAsync ("SelectLanguage");
            SceneManager.LoadScene ("Quiz", LoadSceneMode.Additive);
            sceneLoaded = true;
        }
        languageSceneLoaded = false;
    } 

    public void QuizFormatToLoad() 
    {
        if (sceneLoaded == true)
        {
            SceneManager.UnloadSceneAsync ("Quiz");
            SceneManager.LoadScene ("QuizFormat", LoadSceneMode.Additive);
            formatSceneLoaded = true;
        }
        sceneLoaded = false;
    } 

    public void MainToLoad() 
    {
        if (formatSceneLoaded == true)
        {
            SceneManager.UnloadSceneAsync ("QuizFormat");
        }  
        formatSceneLoaded = false;

        // Lock the cursor 
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}