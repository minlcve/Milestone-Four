using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEndFlag : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Flag touched!");

            int currentIndex = SceneManager.GetActiveScene().buildIndex;
            int nextIndex = currentIndex + 1;

            if (nextIndex < SceneManager.sceneCountInBuildSettings)
            {
                Debug.Log("Loading scene index: " + nextIndex);
                SceneManager.LoadScene(nextIndex);
            }
            else
            {
                Debug.Log("No more scenes. Game over!");
            }
        }
    }
}
