using UnityEngine;

public class LockCameraX : MonoBehaviour
{
    public Transform player;
    private Vector3 playerPosition;
    private Vector3 cameraPosition;

    void Update()
    {
        playerPosition = player.position;
        cameraPosition = transform.position;

        if(playerPosition.y > cameraPosition.y)
        {
            cameraPosition.y = playerPosition.y;
        }

        transform.position = cameraPosition;
    }
}
