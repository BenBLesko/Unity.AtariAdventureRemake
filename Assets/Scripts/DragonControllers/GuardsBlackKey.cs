using UnityEngine;

public class GuardsBlackKey : MonoBehaviour
{
    public Transform blackKeyPosition;
    public Transform player;

    public bool guardBlackKey;
    
    public float Speed;
    public float DistanceToThePlayer;
    public float MaxDistanceToThePlayer;
    public float DistanceToTheBlackKey;
    public float MaxDistanceToTheBlackKey;

    void Start()
    {
        guardBlackKey = false;
    }

    void Update()
    {
        DistanceToThePlayer = Vector3.Distance(transform.position, player.position);
        DistanceToTheBlackKey = Vector3.Distance(transform.position, blackKeyPosition.position);

        if (GameObject.Find("Black Key").GetComponent<ParentCheck>().hasParent == false)
        {
            guardBlackKey = true;
            GetComponent<DragonAI>().Chase = false;
        }
        if (guardBlackKey && DistanceToThePlayer <= MaxDistanceToThePlayer)
        {
            guardBlackKey = false;
            GetComponent<DragonAI>().Chase = true;
        }

        if (guardBlackKey)
        {
            transform.LookAt(blackKeyPosition);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }

        if (GetComponent<GuardsMagnet>().guardMagnet == true && GameObject.Find("Black Key").GetComponent<ParentCheck>().hasParent == false && DistanceToTheBlackKey <= MaxDistanceToTheBlackKey)
        {
            GetComponent<GuardsMagnet>().guardMagnet = false;
            guardBlackKey = true;
            GetComponent<DragonAI>().Chase = false;
        }
    }
}
