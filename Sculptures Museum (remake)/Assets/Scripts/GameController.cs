using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text questionDisplayText;
    public Text scoreDisplayText;
    public SimpleObjectPool answerButtonObjectPool;
    public Transform aswerButtonParent;
    public GameObject questionDisplay;
    public GameObject quizEndDisplay;
    private ScenesManager loadScene;
    private DataController dataController;
    private QuizData currentQuizData;
    private QuestionData[] questionPool;
    public static bool isQuizActive;
    private int questionIndex;
    private int playerScore;
    private List<GameObject> answerButtonGameObjects = new List<GameObject>();

    public static int points;


    void Start()
    {
        loadScene = FindObjectOfType<ScenesManager>();

        dataController = FindObjectOfType<DataController>();

        if (UserData.q == 1 && SelectLanguage.l == 1){
            currentQuizData = dataController.GetQuiz1grData();
        }
        else if (UserData.q == 2 && SelectLanguage.l == 1){
           currentQuizData = dataController.GetQuiz2grData();
        }
        else if (UserData.q == 3 && SelectLanguage.l == 1){
           currentQuizData = dataController.GetQuiz3grData();
        }
        else if (UserData.q == 1 && SelectLanguage.l == 2){
            currentQuizData = dataController.GetQuiz1engData();
        }
        else if (UserData.q == 2 && SelectLanguage.l == 2){
           currentQuizData = dataController.GetQuiz2engData();
        }
        else if (UserData.q == 3 && SelectLanguage.l == 2){
           currentQuizData = dataController.GetQuiz3engData();
        }
        questionPool = currentQuizData.questions;

        playerScore = 0;
        questionIndex = 0;

        ShowQuestion();
        isQuizActive = true;
    }

   

    private void ShowQuestion()
    {
        RemoveAnswerButtons();
       
        QuestionData questionData = questionPool[questionIndex];
        questionDisplayText.text = questionData.questionText;

        for (int i=0; i<questionData.answers.Length; i++){
            GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
            answerButtonGameObjects.Add(answerButtonGameObject);
            answerButtonGameObject.transform.SetParent(aswerButtonParent);

            AnswerButton aswerButton = answerButtonGameObject.GetComponent<AnswerButton>();
            aswerButton.Setup(questionData.answers[i]);
        }
    }

    private void RemoveAnswerButtons()
    {
        while (answerButtonGameObjects.Count > 0){
            answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
            answerButtonGameObjects.RemoveAt(0);
        }
    }

    public void AnswerButtonClicked(bool isCorrect)
    {
        if (isCorrect){
            playerScore += currentQuizData.pointsAdder;
            scoreDisplayText.text = "Score:" + playerScore;
        }
        if (questionPool.Length > questionIndex + 1){
            questionIndex++;
            ShowQuestion();
        }
        else{
            EndQuiz();
        }
    }

    private void EndQuiz()
    {
        isQuizActive = false;
        questionDisplay.SetActive(false);
        quizEndDisplay.SetActive(true);
        scoreDisplayText.text = "Score:" + playerScore;
        points = playerScore;

        dataController = null;
        currentQuizData = null;
        
    }

    public void ReturnToMuseum()
    {	        
        loadScene.MainToLoad();
        setQuizPoints();
    	UserData.updatePoints();
    }

    private void setQuizPoints(){
        if(UserData.q == 1){
            UserData.Q1points = playerScore; 
        }
        else if (UserData.q == 2){
            UserData.Q2points=playerScore;
        }
        else if (UserData.q == 3){
            UserData.Q3points = playerScore;
        }
    }   

    // Update is called once per frame
    void Update()
    {
        
    }
}
