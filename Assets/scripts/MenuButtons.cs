using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public string LevelToLoad = "SampleScene";

    public void playGame(){
        SceneManager.LoadScene(LevelToLoad);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
