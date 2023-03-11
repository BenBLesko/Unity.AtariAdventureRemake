using UnityEngine;

public class ActivateMagnet : MonoBehaviour
{
    public GameObject YellowKey;
    public GameObject YellowSword;
    public GameObject BlackKey;
    // public GameObject WhiteKey;
    public GameObject Bridge;
    public GameObject Chalice;

    public bool hasEntered;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && !hasEntered)
        {
            hasEntered = true;
            YellowKey.GetComponent<Magnet>().enabled = true;
            YellowSword.GetComponent<Magnet>().enabled = true;
            BlackKey.GetComponent<Magnet>().enabled = true;
            Bridge.GetComponent<Magnet>().enabled = true;
            Chalice.GetComponent<Magnet>().enabled = true;
        }
    }
}
