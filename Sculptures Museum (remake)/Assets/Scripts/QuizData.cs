using System.Collections;
using UnityEngine;


[System.Serializable]
public class QuizData 
{
    public string name;
    
    public int pointsAdder;              // Points for correct answer
    public QuestionData[] questions;    // List of q for quiz 1
}
