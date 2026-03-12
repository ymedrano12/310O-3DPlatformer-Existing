using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour
{
    private int Score = 0;
    [SerializeField]
    private TextMeshProUGUI text;

    public void IncreaseScore(){
        Score++;
        Debug.Log("Score: " + Score);
        text.text = "Score: " + Score;

        if(Score >= 3){
            Debug.Log("All houses found");
            text.text = "All houses found!";
            SceneManager.LoadScene("LevelThreeScene");
        }
    }
}
