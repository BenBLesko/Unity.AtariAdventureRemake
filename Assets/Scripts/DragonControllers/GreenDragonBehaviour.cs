using UnityEngine;

public class GreenDragonBehaviour : MonoBehaviour
{
    public GameObject GreenDragon;

    public bool hasEntered;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && !hasEntered)
        {
            hasEntered = true;
            GreenDragon.GetComponent<DragonAI>().enabled = true;
            GreenDragon.GetComponent<GuardsBlackKey>().enabled = true;
        }
    }
}
