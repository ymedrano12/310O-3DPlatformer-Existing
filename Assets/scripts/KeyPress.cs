using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyPress : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("Escape key pressed");
            //FindFirstObjectByType<newLevelTrigger>().OnTriggerEnter();
            SceneManager.LoadScene("Menu");
        }
    }
}
