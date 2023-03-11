using UnityEngine;

public class IsClosed : MonoBehaviour
{
    public GameObject YellowDragon;
    public Transform newYellowDragonPosition;

    public GameObject GreenDragon;
    public Transform newGreenDragonPosition;

    // public GameObject RedDragon;
    // public Transform newRedDragonPosition;

    public GameObject Gate;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Yellow Dragon") && Gate.GetComponent<GateOpening>().isClosed == true)
        {
            YellowDragon.transform.position = newYellowDragonPosition.transform.position;
        }

        if (other.gameObject.layer == LayerMask.NameToLayer("Green Dragon") && Gate.GetComponent<GateOpening>().isClosed == true)
        {
            GreenDragon.transform.position = newGreenDragonPosition.transform.position;
        }

        // if (other.gameObject.layer == LayerMask.NameToLayer("Red Dragon") && Gate.GetComponent<GateOpening>().isClosed == true)
        // {
        // RedDragon.transform.position = newRedDragonPosition.transform.position;
        // }
    }
}
