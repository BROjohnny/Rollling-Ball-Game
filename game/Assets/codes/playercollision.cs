using UnityEngine;

public class playercollision : MonoBehaviour
{

    public playerMovement hit_stop;
    private void OnCollisionEnter(Collision collisionType)
    {
        if (collisionType.collider.tag == "barrier")
        {
            Debug.Log("wtf is that barrier");
            hit_stop.enabled = false;
            FindObjectOfType<GameMana>().GameOver();
        }
        
    }
}
