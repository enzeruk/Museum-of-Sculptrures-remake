using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEgyptianScene : MonoBehaviour
{
    [SerializeField] public AudioClip m_lockSFX;
    [SerializeField] public AudioClip m_unlockSFX;

    private bool egyptianTrigger;
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        egyptianTrigger = false;
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (egyptianTrigger)
        {
            if (UserData.totalPoints < 110)
            {
                if (Input.GetKeyDown("f"))
                {
                    Debug.Log("Locked Egyptian Room");
                    m_AudioSource.clip = m_lockSFX;
                    m_AudioSource.Play();
                }

                // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // RaycastHit hit;
                // if (Physics.Raycast(ray, out hit))
                // {
                //     // Visible only on Scene Mode
                //     Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

                //     if (hit.transform.name == "EgyptianDoor" && Input.GetKeyDown("f"))
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
                    Debug.Log("Load Egyptian scene");
                    m_AudioSource.clip = m_unlockSFX;
                    m_AudioSource.Play();
                    StartCoroutine(LoadNextScene());
                }

                // if (Physics.Raycast(ray, out hit))
                // {
                //     // Visible only on Scene Mode
                //     Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

                //     if (hit.transform.name == "EgyptianDoor" && Input.GetKeyDown("f"))
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

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player")
        {
            egyptianTrigger = true;
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")
        {
            egyptianTrigger = false;
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1.0f);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("VIPEgyptianRoom");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
