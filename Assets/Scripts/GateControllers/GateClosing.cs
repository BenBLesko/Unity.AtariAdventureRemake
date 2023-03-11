using UnityEngine;

public class GateClosing : MonoBehaviour
{
    public GameObject Key;
    public GameObject Gate;
    public GameObject Wall;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Key)
        {
            if (Gate.GetComponent<Collider>().enabled == false)
            {
                Gate.GetComponent<GateOpening>().isClosed = true;

                Gate.GetComponent<Collider>().enabled = true;
                Gate.transform.Translate(0f, -0.75f, 0f);
            }
        }
    }
}
