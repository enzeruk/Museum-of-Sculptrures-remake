using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class EgyptianRoomInfo : MonoBehaviour {
 
	public bool isImgOn;
	public Image akenaten, box, eye, pharaoh, isis, nefertiti, bearers, osiris,
				ramessesII, ramessesIII, redSarco, shawabti, sobek, taweret,
				tut, coffin;
 
	void Start () 
	{
		DisableAllImages();
	}
 
	void Update () {
		if (Input.GetKeyDown ("e")) {

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{
				// Visible only on Scene Mode
				Debug.DrawLine(ray.origin, hit.point, Color.red, 2.5f);

				if (hit.transform.name == "AkenatenInfo"){

					if (isImgOn == true) {
						akenaten.enabled = false;
						isImgOn = false;
					}

					else {
						akenaten.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "BoxInfo"){

					if (isImgOn == true) {
						box.enabled = false;
						isImgOn = false;
					}

					else {
						box.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "EyeInfo"){

					if (isImgOn == true) {
						eye.enabled = false;
						isImgOn = false;
					}

					else {
						eye.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "PharaohInfo"){

					if (isImgOn == true) {
						pharaoh.enabled = false;
						isImgOn = false;
					}

					else {
						pharaoh.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "IsisInfo"){

					if (isImgOn == true) {
						isis.enabled = false;
						isImgOn = false;
					}

					else {
						isis.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "NefertitiInfo"){

					if (isImgOn == true) {
						nefertiti.enabled = false;
						isImgOn = false;
					}

					else {
						nefertiti.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "BearersInfo"){

					if (isImgOn == true) {
						bearers.enabled = false;
						isImgOn = false;
					}

					else {
						bearers.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "OsirisInfo"){

					if (isImgOn == true) {
						osiris.enabled = false;
						isImgOn = false;
					}

					else {
						osiris.enabled = true;
						isImgOn = true;
					}
				}

				else if (hit.transform.name == "RamessesIIInfo"){

					if (isImgOn == true) {
						ramessesII.enabled = false;
						isImgOn = false;
					}

					else {
						ramessesII.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "RamessesIIIInfo"){

					if (isImgOn == true) {
						ramessesIII.enabled = false;
						isImgOn = false;
					}

					else {
						ramessesIII.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "RedSarcoInfo"){

					if (isImgOn == true) {
						redSarco.enabled = false;
						isImgOn = false;
					}

					else {
						redSarco.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "ShawabtiInfo"){

					if (isImgOn == true) {
						shawabti.enabled = false;
						isImgOn = false;
					}

					else {
						shawabti.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "SobekInfo"){

					if (isImgOn == true) {
						sobek.enabled = false;
						isImgOn = false;
					}

					else {
						sobek.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "TaweretInfo"){

					if (isImgOn == true) {
						taweret.enabled = false;
						isImgOn = false;
					}

					else {
						taweret.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "TutInfo"){

					if (isImgOn == true) {
						tut.enabled = false;
						isImgOn = false;
					}

					else {
						tut.enabled = true;
						isImgOn = true;
					}
				}	

				else if (hit.transform.name == "CoffinInfo"){

					if (isImgOn == true) {
						coffin.enabled = false;
						isImgOn = false;
					}

					else {
						coffin.enabled = true;
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
		akenaten.enabled = false;
		box.enabled = false;
		eye.enabled = false;
		pharaoh.enabled = false;
		isis.enabled = false;
		nefertiti.enabled = false;
		bearers.enabled = false;
		osiris.enabled = false;
		ramessesII.enabled = false;
		ramessesIII.enabled = false;
		redSarco.enabled = false;
		shawabti.enabled = false;
		sobek.enabled = false;
		taweret.enabled = false;
		tut.enabled = false;
		coffin.enabled = false;
		isImgOn = false;
	}
}