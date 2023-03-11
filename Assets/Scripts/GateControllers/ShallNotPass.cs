using UnityEngine;

public class ShallNotPass : MonoBehaviour
{
    public GameObject YellowDragon;
    public Transform newYellowDragonPosition;

    public GameObject GreenDragon;
    public Transform newGreenDragonPosition;

    // public GameObject RedDragon;
    // public Transform newRedDragonPosition;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Yellow Dragon"))
        {
            YellowDragon.transform.position = newYellowDragonPosition.transform.position;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Green Dragon"))
        {
            GreenDragon.GetComponent<GuardsBlackKey>().enabled = false;
            GreenDragon.transform.position = newGreenDragonPosition.transform.position;
        }

        // if (other.gameObject.layer == LayerMask.NameToLayer("Red Dragon"))
        // {
            // RedDragon.transform.position = newRedDragonPosition.transform.position;
        // }
    }
}
