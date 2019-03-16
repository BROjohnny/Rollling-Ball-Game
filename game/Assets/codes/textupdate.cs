using UnityEngine.UI;
using UnityEngine;

public class textupdate : MonoBehaviour
{
    public Transform Player;
    public Text scoreBoard;
    // Update is called once per frame
    void Update()
    {
        scoreBoard.text =  Player.position.z.ToString("0");
     }
}
