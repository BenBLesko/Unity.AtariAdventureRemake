using UnityEngine;

public class GateOpening : MonoBehaviour
{
    public GameObject Key;
    public GameObject Gate;

    public bool isClosed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Key)
        {
            isClosed = false;

            Gate.GetComponent<Collider>().enabled = false;
            Gate.transform.Translate(0f, 0.75f, 0f);    
        }
    }
}
