using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChineseDoorTriggerText : MonoBehaviour
{

    [SerializeField] public Text pointsToOpen;
    [SerializeField] public Text openDoor;

    // Start is called before the first frame update
    void Start()
    {
        pointsToOpen.enabled = false;
        openDoor.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && UserData.totalPoints < 60)
        {
            pointsToOpen.enabled = true;
        }

        else
        {
            openDoor.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pointsToOpen.enabled = false;
            openDoor.enabled = false;
        }
    }
}

