using UnityEngine;

public class ResetPlayerColour : MonoBehaviour
{
    public Material newMaterial;
    public GameObject Player;

    void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<MeshRenderer>().material = newMaterial;
    }
}
