using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGreekScene : MonoBehaviour
{
    [SerializeField] public AudioClip m_unlockSFX;
    [SerializeField] public Text openDoor;
    
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        openDoor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (openDoor.enabled == true)
        {
            if (Input.GetKeyDown("f"))
            {
                m_AudioSource.clip = m_unlockSFX;
                m_AudioSource.Play();
                StartCoroutine(LoadNextScene());
            }
        }
        
        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;

        // if (Physics.Raycast(ray, out hit) && openDoor.enabled == true)
        // {
        //     // Visible only on Scene Mode
        //     Debug.DrawLine(ray.origin, hit.point, Color.red, 0.5f);

        //     Debug.Log("Hits : " + hit.transform.name.ToString());

        //     if (hit.transform.name == "MainDoor" && Input.GetKeyDown("f"))
        //     {
        //         Debug.Log("F from outside");
        //         m_AudioSource.clip = m_unlockSFX;
        //         m_AudioSource.Play();
        //         StartCoroutine(LoadNextScene());
        //     }
        // }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {   
            openDoor.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            openDoor.enabled = false;
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1.0f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("GreekRoom");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
