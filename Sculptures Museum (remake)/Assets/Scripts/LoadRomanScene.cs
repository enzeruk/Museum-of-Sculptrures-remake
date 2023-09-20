using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRomanScene : MonoBehaviour
{
    [SerializeField] public AudioClip m_lockSFX;
    [SerializeField] public AudioClip m_unlockSFX;

    private AudioSource m_AudioSource;
    private bool romanTrigger;

    // Start is called before the first frame update
    void Start()
    {
        romanTrigger = false;
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (romanTrigger)
        {
            if (UserData.totalPoints < 40)
            {
                if (Input.GetKeyDown("f"))
                {
                    m_AudioSource.clip = m_lockSFX;
                    m_AudioSource.Play();
                }

                // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // RaycastHit hit;
                // if (Physics.Raycast(ray, out hit))
                // {
                //     // Visible only on Scene Mode
                //     Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

                //     Debug.Log("ROMAN: HIT @ " + hit.transform.name.ToString());

                //     if (hit.transform.name == "RomanDoor" && Input.GetKeyDown("f"))
                //     {
                //         Debug.Log("F");
                //         m_AudioSource.clip = m_lockSFX;
                //         m_AudioSource.Play();
                //     }
                // }
            }

            else
            {
                if (Input.GetKeyDown("f"))
                {
                    m_AudioSource.clip = m_unlockSFX;
                    m_AudioSource.Play();
                    StartCoroutine(LoadNextScene());
                }

                // if (Physics.Raycast(ray, out hit))
                // {
                //     // Visible only on Scene Mode
                //     Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

                //     if (hit.transform.name == "RomanDoor" && Input.GetKeyDown("f"))
                //     {
                //         Debug.Log("F");
                //         m_AudioSource.clip = m_unlockSFX;
                //         m_AudioSource.Play();
                //         StartCoroutine(LoadNextScene());
                //     }
                // }
            }
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )
        {   
            romanTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            romanTrigger = false;
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1.0f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("RomanRoom");
        
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
