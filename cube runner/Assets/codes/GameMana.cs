using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMana : MonoBehaviour
{
    bool IsgameEnded = false;

    public GameObject restartlevel;

    public GameObject CompleteLevelUI;
    public GameObject CollisionUI;
    public void LevelComplte()
    {
        CompleteLevelUI.SetActive(true);
    }
    public void GameOver()
    {
        if (IsgameEnded == false) { 
            Debug.Log("Game Over");
            IsgameEnded = true;
            CollisionUI.SetActive(true);
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
