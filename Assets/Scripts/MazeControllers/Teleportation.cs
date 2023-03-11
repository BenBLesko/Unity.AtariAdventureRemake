using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportPlayer;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = teleportPlayer.transform.position;
    }
}
