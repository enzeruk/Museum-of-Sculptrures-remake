using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadOutsideScene : MonoBehaviour
{
    [SerializeField] public AudioClip m_unlockSFX;
    [SerializeField] public Text openDoor;

    private AudioSource m_AudioSource;
    private bool exitTrigger;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        openDoor.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (exitTrigger)
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

        // if (Physics.Raycast(ray, out hit))
        // {
        //     // Visible only on Scene Mode
        //     Debug.DrawLine(ray.origin, hit.point, Color.red, 1.5f);

        //     if (hit.transform.name == "mainOutside" && Input.GetKeyDown("f"))
        //     {
        //         Debug.Log("F");
        //         m_AudioSource.clip = m_unlockSFX;
        //         m_AudioSource.Play();
        //         StartCoroutine(LoadNextScene());
        //     }
        // }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            exitTrigger = true;
            openDoor.enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            exitTrigger = false;
            openDoor.enabled = false;
        }
    }

    IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("MuseumArea");
    }
}
