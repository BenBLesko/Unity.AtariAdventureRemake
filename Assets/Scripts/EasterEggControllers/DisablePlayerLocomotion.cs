using UnityEngine;

public class DisablePlayerLocomotion : MonoBehaviour
{
    public GameObject Player;
    public GameObject YellowDragon;
    public GameObject GreenDragon;
    // public GameObject RedDragon;

    public Material newMaterial;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.GetComponent<PlayerLocomotion>().enabled = false;
            Player.GetComponent<MeshRenderer>().material = newMaterial;

            YellowDragon.GetComponent<DragonAI>().enabled = false;
            GreenDragon.GetComponent<DragonAI>().enabled = false;
            // RedDragon.GetComponent<DragonAI>().enabled = false;
        }
    }
}
