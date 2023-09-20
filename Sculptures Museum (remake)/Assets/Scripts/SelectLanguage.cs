using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLanguage : MonoBehaviour
{
    private ScenesManager loadScene;
    public static int l;
    private int q;

    void Start(){
    	loadScene = FindObjectOfType<ScenesManager>();
		// DontDestroyOnLoad(gameObject);
		q =- 1;
		l = 0;
    }
    
    public void LoadQuizgr(){
		q = UserData.q;
		l = 1;
		loadScene.QuizToLoad();						  
    }

    public void LoadQuizeng(){
		q = UserData.q;
		l = 2;
		loadScene.QuizToLoad();
    }
}
