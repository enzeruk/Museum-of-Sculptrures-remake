using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadChineseScene : MonoBehaviour
{
    [SerializeField] public AudioClip m_lockSFX;
    [SerializeField] public AudioClip m_unlockSFX;

    private AudioSource m_AudioSource;
    private bool chineseTrigger;

    // Start is called before the first frame update
    void Start()
    {
        chineseTrigger = false;
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (chineseTrigger)
        {
            if (UserData.totalPoints < 60)
            {
                if (Input.GetKeyDown("f"))
                {
                    m_AudioSource.clip = m_lockSFX;
                    m_AudioSource.Play();
                }
            }

            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // RaycastHit hit;

            // if (UserData.totalPoints < 60)
            // {
            //     if (Physics.Raycast(ray, out hit))
            //     {
            //         Debug.Log("CHINESE: HIT @ " + hit.transform.name.ToString());
            //         // Visible only on Scene Mode
            //         Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

            //         if (hit.transform.name == "ChineseDoor" && Input.GetKeyDown("f"))
            //         {
            //             Debug.Log("F");
            //             m_AudioSource.clip = m_lockSFX;
            //             m_AudioSource.Play();
            //         }
            //     }
            // }

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

                //     if (hit.transform.name == "ChineseDoor" && Input.GetKeyDown("f"))
                //     {
                //         Debug.Log("F to: " + hit.transform.name.ToString());
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
        if (other.tag == "Player")
        {
            chineseTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            chineseTrigger = false;
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1.0f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("ChineseRoom");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
