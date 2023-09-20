using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class AsianRoomInfo : MonoBehaviour {
 
	public bool isImgOn;
	public Image buddha, lion, ganesha, panel, bench;
 
	void Start () 
	{
		buddha.enabled = false;
		lion.enabled = false;
		ganesha.enabled = false;
		panel.enabled = false;
		bench.enabled = false;
		isImgOn = false;
	}
 
	void Update () 
	{
		if (Input.GetKeyDown ("e")){

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit)){

				// Visible only on Scene Mode
				Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

				if (hit.transform.name == "BuddhaInfo"){

					if (isImgOn == true) {
						buddha.enabled = false;
						isImgOn = false;
					}

					else {
						buddha.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "LionInfo"){

					if (isImgOn == true) {
						lion.enabled = false;
						isImgOn = false;
					}

					else {
						lion.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "GaneshaInfo"){

					if (isImgOn == true) {
						ganesha.enabled = false;
						isImgOn = false;
					}

					else {
						ganesha.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "PanelInfo"){

					if (isImgOn == true) {
						panel.enabled = false;
						isImgOn = false;
					}

					else {
						panel.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "BenchInfo"){

					if (isImgOn == true) {
						bench.enabled = false;
						isImgOn = false;
					}

					else {
						bench.enabled = true;
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
		buddha.enabled = false;
		lion.enabled = false;
		ganesha.enabled = false;
		panel.enabled = false;
		bench.enabled = false;
		isImgOn = false;
	}
}