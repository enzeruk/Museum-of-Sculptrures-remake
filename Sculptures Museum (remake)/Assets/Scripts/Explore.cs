using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explore : MonoBehaviour
{
    public Text pointsText;
    private ScenesManager loadScene;
    public static int counterQuiz1;
    public static int counterQuiz2;
    public static int counterQuiz3; 

    // Start is called before the first frame update
    void Start()
    {	
    	counterQuiz1 = 0;
    	counterQuiz2 = 0;
    	counterQuiz3 = 0;
		loadScene = FindObjectOfType<ScenesManager>();
    }

    public void quizStation1(){
        UserData.q = 1;
        UserData.counter++;
        loadScene.SelectLanguageToLoad();
    }

    public void quizStation2(){
        UserData.q = 2;
        UserData.counter++;
        loadScene.SelectLanguageToLoad();
    }

    public void quizStation3(){
        UserData.q = 3;   
        UserData.counter++;
        loadScene.SelectLanguageToLoad();
    }

    // Update player's score
	void  setPointsText()
	{
        if(UserData.flag == 1){
            pointsText.text = "Score: " + UserData.totalPoints;
            UserData.flag = 0;
        }	
	}

    // Update is called once per frame
    void Update()
    {	
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

		if (Physics.Raycast(ray, out hit, 20) ){
            
            if((hit.transform.tag == "gameStation1") && (Input.GetKeyDown ("q"))){
            	counterQuiz1++;
	            
	            if (counterQuiz1 > 1)
	            {
	            	Debug.Log("You cannot play this quiz again.");
	            }
	            else
	            {
                	quizStation1();	
	            }
            }
            else if((hit.transform.tag =="gameStation2") && (Input.GetKeyDown ("q"))){
                counterQuiz2++;
                
                if (counterQuiz2 > 1)
	            {
	            	Debug.Log("You cannot play this quiz again.");
	            }
	            else
	            {
                	quizStation2();	
	            }
            }
            else if((hit.transform.tag =="gameStation3") && (Input.GetKeyDown ("q"))){
                counterQuiz3++;
                
                if (counterQuiz3 > 1)
	            {
	            	Debug.Log("You cannot play this quiz again.");
	            }
	            else
	            {
                	quizStation3();	
	            }
            }

        }  

		setPointsText();
    }

}
