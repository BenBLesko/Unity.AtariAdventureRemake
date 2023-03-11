using UnityEngine;

public class GuardsMagnet : MonoBehaviour
{
    public Transform magnetPosition;
    public Transform player;

    public bool guardMagnet;
    
    public float Speed;
    public float DistanceToThePlayer;
    public float MaxDistanceToThePlayer;
    public float DistanceToTheMagnet;
    public float MaxDistanceToTheMagnet;

    void Start()
    {
        guardMagnet = false;
    }

    void Update()
    {
        DistanceToThePlayer = Vector3.Distance(transform.position, player.position);
        DistanceToTheMagnet = Vector3.Distance(transform.position, magnetPosition.position);

        if (GameObject.Find("Magnet").GetComponent<ParentCheck>().hasParent == false && DistanceToTheMagnet <= MaxDistanceToTheMagnet)
        {
            guardMagnet = true;
            GetComponent<GuardsBlackKey>().guardBlackKey = false;
            GetComponent<DragonAI>().Chase = false;
        }
        if (guardMagnet && DistanceToThePlayer <= MaxDistanceToThePlayer)
        {
            guardMagnet = false;
            GetComponent<DragonAI>().Chase = true;
        }

        if (guardMagnet)
        {
            transform.LookAt(magnetPosition);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }

        if (GetComponent<GuardsBlackKey>().guardBlackKey == true && GameObject.Find("Magnet").GetComponent<ParentCheck>().hasParent == false && DistanceToTheMagnet <= MaxDistanceToTheMagnet)
        {
            GetComponent<GuardsBlackKey>().guardBlackKey = false;
            guardMagnet = true;
            GetComponent<DragonAI>().Chase = false;
        }

    }
}
