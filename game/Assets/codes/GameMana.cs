using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMana : MonoBehaviour
{
    bool IsgameEnded = false;

    public GameObject CompleteLevelUI;

    public void LevelComplte()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void GameOver()
    {
        if (IsgameEnded == false) { 
            Debug.Log("Game Over");
            IsgameEnded = true;
            Invoke("Restart", 1f);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
