using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroyOnLoad : MonoBehaviour
{
    private static DoNotDestroyOnLoad scoreInstance;

    // Do not destroy the score object on the next scene load
    void Awake()
    {
        // GameObject obj = GameObject.FindGameObjectWithTag("Score");
        DontDestroyOnLoad(this.gameObject);

        if (scoreInstance == null)
        {
            scoreInstance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
