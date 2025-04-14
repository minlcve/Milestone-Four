using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagWin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            string currentScene = SceneManager.GetActiveScene().name;

            if (currentScene == "GameScene")
            {
                SceneManager.LoadScene("Level2Scene");
            }
            else if (currentScene == "Level2Scene")
            {
                SceneManager.LoadScene("Level3Scene");
            }
            else if (currentScene == "Level3Scene")
            {
                SceneManager.LoadScene("YouWinScene");
            }
        }
    }
}
