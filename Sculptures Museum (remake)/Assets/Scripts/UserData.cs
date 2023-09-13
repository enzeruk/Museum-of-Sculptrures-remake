using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserData : MonoBehaviour
{
    public static int totalPoints;
    public static int Q1points;
    public static int Q2points;
    public static int Q3points;
    public static int q;
    public static int counter;
    public static int check;
    public static int flag;
    public static Vector3 pos;
    
    // Start is called before the first frame update
    void Start()
    {
        totalPoints = 0;
        Q1points = 0;
        Q2points = 0;
        Q3points = 0;
        flag = 0;
        counter = 0;
        check = 0;
        q = 0;
    }

   
     public static void updatePoints(){
        
        if(UserData.counter > UserData.check){
            flag = 1;
            totalPoints = Q1points + Q2points + Q3points;
            check = counter;  
        }
    }   
}
