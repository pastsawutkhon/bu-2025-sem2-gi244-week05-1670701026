using UnityEngine;

public class GameState : MonoBehaviour
{
    public int hitCount = 0;

    void OnTriggerEnter(Collider other)
    {
        hitCount++;
        if (hitCount >= 5)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0f;
        }
    }
}
