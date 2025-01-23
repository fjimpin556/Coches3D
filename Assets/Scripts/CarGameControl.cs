using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CarGameControl : MonoBehaviour
{
    [SerializeField] GameObject meta;
    [SerializeField] GameObject checkp;
    [SerializeField] TMP_Text tLap;
    public int lap = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            meta.SetActive(true);
            checkp.SetActive(false);
        }
        else if (other.gameObject.tag == "Meta")
        {
            meta.SetActive(false);
            checkp.SetActive(true);
            lap = lap + 1;
            if (lap > 3)
            {
                tLap.text = "End";
                Invoke("goToCredits", 5);
            }
            else if (lap>2)
            {
                tLap.text = "Lap 3/3";
            }
            else
            {
                tLap.text = "Lap 2/3";
            }
        }
    }

    void goToCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
