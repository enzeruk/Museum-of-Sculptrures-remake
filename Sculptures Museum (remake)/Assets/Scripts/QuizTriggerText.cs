using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizTriggerText : MonoBehaviour
{
    [SerializeField] public Text playQuiz;

    [SerializeField] public Text cannotPlayQuiz;

    // Start is called before the first frame update
    void Start()
    {
        playQuiz.enabled = false;
        cannotPlayQuiz.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Visible only on Scene Mode
		    Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

            if (hit.transform.name == "gameStation1")
            {
                if (other.tag == "Player" && Explore.counterQuiz1 == 0)
                {
                    playQuiz.enabled = true;
                    cannotPlayQuiz.enabled = false;
                    StartCoroutine(DisableTriggerTxt());
                }

                else
                {
                    playQuiz.enabled = false;
                    cannotPlayQuiz.enabled = true;
                }
            }
            if (hit.transform.name == "gameStation2")
            {
                if (other.tag == "Player" && Explore.counterQuiz2 == 0)
                {
                    playQuiz.enabled = true;
                    cannotPlayQuiz.enabled = false;
                    StartCoroutine(DisableTriggerTxt());
                }

                else
                {
                    playQuiz.enabled = false;
                    cannotPlayQuiz.enabled = true;
                }
            }
            if (hit.transform.name == "gameStation3")
            {
                if (other.tag == "Player" && Explore.counterQuiz3 == 0)
                {
                    playQuiz.enabled = true;
                    cannotPlayQuiz.enabled = false;
                    StartCoroutine(DisableTriggerTxt());
                }

                else
                {
                    playQuiz.enabled = false;
                    cannotPlayQuiz.enabled = true;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playQuiz.enabled = false;
            cannotPlayQuiz.enabled = false;
        }
    }

    IEnumerator DisableTriggerTxt()
    {
        // Disable the Quiz trigger txt, so when the Player finishes the Quiz, the trigger txt will not be visible anymore 
        yield return new WaitForSeconds(10);
        playQuiz.enabled = false;
    }
}
