using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevelTrigger : MonoBehaviour
{
    public string LevelToLoad = "LevelTwoScene";
    
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Debug.Log("I have found a player");
            SceneManager.LoadScene(LevelToLoad);
        }
    }

    // private void OnCollisionEnter(Collision collision){
    //     if(collision.collider.CompareTag("Player")){
    //         Debug.Log("Player has collided");
    //     }
    // }
}
