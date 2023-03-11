using UnityEngine;

public class ChaliceDistanceCheck : MonoBehaviour
{
    public Transform chalicePosition;

    public float DistanceToTheChalice;

    void Update()
    {
        DistanceToTheChalice = Vector3.Distance(transform.position, chalicePosition.position);
    }
}
