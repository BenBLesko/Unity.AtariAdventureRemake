using UnityEngine;

public class Pickup : MonoBehaviour
{
    [HideInInspector]
    public Vector3 Position;

    [HideInInspector]
    public string keyName;

    [HideInInspector]
    public int currentRoom = -1;
}
