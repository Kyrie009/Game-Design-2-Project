using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 currentPos;
    //reference
    public Transform respawnPoint;

    void Update()
    {
        //Updates current position
        currentPos = this.transform.position;
        // respawn if condition met
        if (currentPos.y < 25)
        {
            this.transform.position = respawnPoint.position;
        }
    }
}
