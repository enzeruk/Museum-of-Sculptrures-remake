using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Help : MonoBehaviour
{
	public bool isImgOn;
	public bool flag;
	public Image help;

	void Start ()
    {
		flag = false;
		isImgOn = false;
		help.enabled = false;
    }

	void Update()
	{
		if (Input.GetButton("Help"))
		{
			// If instructions are already being displayed
			if (isImgOn == true && flag == false)
			{
				flag = true;
				help.enabled = false;
				isImgOn = false;
				StartCoroutine(FailSafe());
			}

			if (isImgOn == false && flag == false)
			{
				flag = true;
				help.enabled = true;
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
}