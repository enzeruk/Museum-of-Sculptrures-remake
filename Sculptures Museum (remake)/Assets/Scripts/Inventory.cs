using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Inventory : MonoBehaviour
{

	public bool isImgOn;
	public bool flag;
	public Image inventory;

	void Start()
	{
		flag = false;
		isImgOn = false;
		inventory.enabled = false;
	}

	void Update()
	{
		if (Input.GetButton("Inventory") && UserData.totalPoints >= 120)
		{
			// If the certificate is already being displayed
			if (isImgOn == true && flag == false)
			{
				flag = true;
				inventory.enabled = false;
				isImgOn = false;
				StartCoroutine(FailSafe());
			}

			if (isImgOn == false && flag == false)
			{
				flag = true;
				inventory.enabled = true;
				isImgOn = true;
				StartCoroutine(FailSafe());
			}
		}
	}

	IEnumerator FailSafe()
	{
		yield return new WaitForSeconds(0.25f);
		flag = false;
	}

	/*
	public Button button;
	public bool buttonisclicked, isOn;
	public Image img;

	void Start ()
	{
		Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(ButtonPressed);
		buttonisclicked = false;
		img.enabled = false;
		isOn = false;
	}


	void ButtonPressed()
	{
		buttonisclicked = true;

		if((buttonisclicked == true) && UserData.totalPoints >= 120)
		{
			if (isOn) 
			{
				img.enabled = false;
				isOn = false;
			}

			else 
			{
				img.enabled = true;
				isOn = true;
			}
		}
	}

	void Update()
	{
		
	}
	*/
}