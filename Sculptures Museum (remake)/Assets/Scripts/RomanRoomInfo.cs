using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class RomanRoomInfo : MonoBehaviour {
 
	public bool isImgOn;
	public Image aurelius, david, trajan;
 
	void Start () 
	{
		DisableAllImages();
	}
 
	void Update () 
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Input.GetKeyDown ("e")) {
			if (Physics.Raycast(ray, out hit)){

				// Visible only on Scene Mode
				Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

				if (hit.transform.name == "AureliusInfo") {

					if (isImgOn == true) {
						aurelius.enabled = false;
						isImgOn = false;
					}

					else {
						aurelius.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "DavidInfo") {

					if (isImgOn == true) {
						david.enabled = false;
						isImgOn = false;
					}

					else {
						david.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "TrajanInfo") {

					if (isImgOn == true) {
						trajan.enabled = false;
						isImgOn = false;
					}

					else {
						trajan.enabled = true;
						isImgOn = true;
					}
				}
				else {
					DisableAllImages();
				}
			}
		}
	}

	void DisableAllImages()
	{
		aurelius.enabled = false;
		david.enabled = false;
		trajan.enabled = false;
		isImgOn = false;
	}
}