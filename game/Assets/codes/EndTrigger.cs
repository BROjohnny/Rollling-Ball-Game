using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameMana GM;

    void OnTriggerEnter ()
    {
        GM.LevelComplte();
    }
}
