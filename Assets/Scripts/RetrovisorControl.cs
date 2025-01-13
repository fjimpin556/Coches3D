using UnityEngine;

public class RetrovisorControl : MonoBehaviour
{
    [SerializeField] GameObject retrovisor;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            retrovisor.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.R)){
            retrovisor.SetActive(false);
        }
    }
}
