using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class GreekRoomInfo : MonoBehaviour {

	[SerializeField] public GameObject player;
	public bool isImgOn;
	public Image sphinx, jason, pythagore, discobolus, demosthenes, amazon,
				athenaFarn, athenaLemnia, venus, asclepius, ariadne;
	
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

				if (hit.transform.name == "SphinxInfo") {

					if (isImgOn == true) {
						sphinx.enabled = false;
						isImgOn = false;
					}

					else {
						sphinx.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "JasonInfo") {

					if (isImgOn == true) {
						jason.enabled = false;
						isImgOn = false;
					}

					else {
						jason.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "PythagoreInfo") {

					if (isImgOn == true) {
						pythagore.enabled = false;
						isImgOn = false;
					}

					else {
						pythagore.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "DiscobolusInfo") {
					if (isImgOn == true) {
						discobolus.enabled = false;
						isImgOn = false;
					}

					else {
						discobolus.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "DemosthenesInfo") {

					if (isImgOn == true) {
						demosthenes.enabled = false;
						isImgOn = false;
					}

					else {
						demosthenes.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "AmazonInfo") {

					if (isImgOn == true) {
						amazon.enabled = false;
						isImgOn = false;
					}

					else {
						amazon.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "AthenaFarnInfo") {

					if (isImgOn == true) {
						athenaFarn.enabled = false;
						isImgOn = false;
					}

					else {
						athenaFarn.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "AthenaLemniaInfo") {

					if (isImgOn == true) {
						athenaLemnia.enabled = false;
						isImgOn = false;
					}

					else {
						athenaLemnia.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "VenusInfo") {

					if (isImgOn == true) {
						venus.enabled = false;
						isImgOn = false;
					}

					else {
						venus.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "AsclepiusInfo") {

					if (isImgOn == true) {
						asclepius.enabled = false;
						isImgOn = false;
					}

					else {
						asclepius.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "AriadneInfo") {

					if (isImgOn == true) {
						ariadne.enabled = false;
						isImgOn = false;
					}

					else {
						ariadne.enabled = true;
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
		sphinx.enabled = false;
		jason.enabled = false;
		pythagore.enabled = false;
		discobolus.enabled = false;
		demosthenes.enabled = false;
		amazon.enabled = false;
		athenaFarn.enabled = false;
		athenaLemnia.enabled = false;
		venus.enabled = false;
		asclepius.enabled = false;
		ariadne.enabled = false;
		isImgOn = false;
	}
}