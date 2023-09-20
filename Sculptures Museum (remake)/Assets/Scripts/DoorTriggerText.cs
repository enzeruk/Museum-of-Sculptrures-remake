using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorTriggerText : MonoBehaviour
{

    [SerializeField] public Text pointsToOpen;
    [SerializeField] public Text openDoor;

    // Start is called before the first frame update
    void Start()
    {
        pointsToOpen.enabled = false;
        openDoor.enabled = false;
    }

    void OnTriggerEnter (Collider other)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Visible only on Scene Mode
		    Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

            if (hit.transform.name == "RomanDoor")
            {
                if (other.tag == "Player" && UserData.totalPoints < 40)
                {
                    pointsToOpen.enabled = true;
                }

                else
                {
                    openDoor.enabled = true;
                }
            }
            if (hit.transform.name == "ChineseDoor")
            {
                if (other.tag == "Player" && UserData.totalPoints < 70)
                {
                    pointsToOpen.enabled = true;
                }

                else
                {
                    openDoor.enabled = true;
                }
            }
            if (hit.transform.name == "EgyptianDoor")
            {
                if (other.tag == "Player" && UserData.totalPoints < 120)
                {
                    pointsToOpen.enabled = true;
                }

                else
                {
                    openDoor.enabled = true;
                }
            }
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            pointsToOpen.enabled = false;
            openDoor.enabled = false;
        }
    }
}
