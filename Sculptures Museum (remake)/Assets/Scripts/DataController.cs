using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour
{
    
    public QuizData[] quiz1gr;
    public QuizData[] quiz2gr;
    public QuizData[] quiz3gr;
    public QuizData[] quiz1eng;
    public QuizData[] quiz2eng;
    public QuizData[] quiz3eng; 
    private ScenesManager loadScene;

    private static DataController dataCtrlInstance;

    void Start()
    {
        loadScene = FindObjectOfType<ScenesManager>();
        DontDestroyOnLoad(gameObject);
        loadScene.QuizFormatToLoad();

        if (dataCtrlInstance == null)
        {
            dataCtrlInstance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    public QuizData GetQuiz1grData(){
        return quiz1gr[0];
    }

    public QuizData GetQuiz2grData(){
        return quiz2gr[0];
    }
    public QuizData GetQuiz3grData(){
        return quiz3gr[0];
    }

    public QuizData GetQuiz1engData(){
        return quiz1eng[0];
    }

    public QuizData GetQuiz2engData(){
        return quiz2eng[0];
    }
    public QuizData GetQuiz3engData(){
        return quiz3eng[0];
    }



    void Update()
    {

    }
}
