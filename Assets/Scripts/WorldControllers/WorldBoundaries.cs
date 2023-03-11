using UnityEngine;

public class WorldBoundaries : MonoBehaviour
{
    public Transform BounceBack;
    public GameObject Player;

    public AudioSource PlayerDiesSFX;

    void OnTriggerEnter(Collider other)
    {
        PlayerDiesSFX.Play();
        Player.transform.position = BounceBack.transform.position;
    }
}
