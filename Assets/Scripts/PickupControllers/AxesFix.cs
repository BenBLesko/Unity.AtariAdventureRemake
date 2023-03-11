using UnityEngine;

public class AxesFix : MonoBehaviour
{
    Transform otherTransform;
    
    void Start()
    {
        otherTransform = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, otherTransform.position.y, transform.position.z);
    }
}
