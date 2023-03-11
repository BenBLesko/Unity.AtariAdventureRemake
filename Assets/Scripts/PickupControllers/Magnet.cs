using UnityEngine;

public class Magnet : MonoBehaviour
{
    public Transform magnet;
    
    public bool Magnetize = false;
    public float Speed;
    public float DistanceToTarget;
    public float MaxDistanceToTarget;

    public GameObject PickupItem;

    void Update()
    {
        DistanceToTarget = Vector3.Distance(transform.position, magnet.position);

        if (DistanceToTarget < MaxDistanceToTarget && PickupItem.transform.parent == null)
        {
            Magnetize = true;
        }
        else
        {
            Magnetize = false;
        }

        if (Magnetize && DistanceToTarget <= MaxDistanceToTarget && PickupItem.transform.parent == null)
        {
            transform.LookAt(magnet);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }
    }
}
