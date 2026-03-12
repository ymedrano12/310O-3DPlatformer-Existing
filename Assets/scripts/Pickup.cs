using UnityEngine;

public class Pickup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            Debug.Log("Pickup trigger entered");
            FindFirstObjectByType<ScoreUI>().IncreaseScore();
            Destroy(gameObject);
        }
    }
}
