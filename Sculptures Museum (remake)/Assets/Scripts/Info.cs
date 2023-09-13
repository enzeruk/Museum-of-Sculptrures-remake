using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class Info : MonoBehaviour {
 
	public bool isImgOn;
	[SerializeField] public Image info;
	// [SerializeField] public gameObject Player;
 
	void Start () {
		info.enabled = false;
		isImgOn = false;
	}
 
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast(ray, out hit)){

			// Visible only on Scene Mode
			Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

			if (Input.GetKeyDown ("i")){

				if (isImgOn == false && hit.transform.name == "infoTile") {
					info.enabled = true;
					isImgOn = true;
				}
				// Player must be able to close the infoTile image even if the camera looks elsewhere
				else {
					info.enabled = false;
					isImgOn = false;
				}
			}
		}
	}
}