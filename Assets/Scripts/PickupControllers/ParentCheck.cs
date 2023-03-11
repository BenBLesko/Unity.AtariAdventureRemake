using UnityEngine;

public class ParentCheck : MonoBehaviour
{
    public bool hasParent;

    void Update()
    {
        if (transform.parent != null)
        {
            hasParent = true;
        }
        else 
        {
            hasParent = false;
        }
    }
}
