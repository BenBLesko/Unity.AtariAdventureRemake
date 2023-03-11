using UnityEngine;

public class YellowDragonBehaviour : MonoBehaviour
{
    public GameObject YellowDragon;

    public bool hasEntered;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && !hasEntered)
        {
            hasEntered = true;
            YellowDragon.GetComponent<DragonAI>().enabled = true;
            GameObject.Find("Yellow Dragon").GetComponent<DragonAI>().Chase = enabled;
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Yellow Key") && !hasEntered)
        {
            hasEntered = true;
            YellowDragon.GetComponent<YellowDragonFlees>().enabled = true;
        }
        if (other.gameObject.layer == LayerMask.NameToLayer("Yellow Dragon") && hasEntered)
        {
            YellowDragon.GetComponent<YellowDragonFlees>().enabled = true;
        }
    }
}
