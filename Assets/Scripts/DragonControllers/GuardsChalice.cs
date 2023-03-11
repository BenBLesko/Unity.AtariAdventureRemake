using UnityEngine;

public class GuardsChalice : MonoBehaviour
{
    public Transform chalicePosition;
    public Transform player;

    public bool guardChalice;
    
    public float Speed;
    public float DistanceToThePlayer;
    public float MaxDistanceToThePlayer;

    void Start()
    {
        guardChalice = false;    
    }

    void Update()
    {
        DistanceToThePlayer = Vector3.Distance(transform.position, player.position);

        if (GameObject.Find("Chalice").GetComponent<ParentCheck>().hasParent == false)
        {
            guardChalice = true;
            GetComponent<DragonAI>().Chase = false;
        }
        if (guardChalice && DistanceToThePlayer <= MaxDistanceToThePlayer)
        {
            guardChalice = false;
            GetComponent<DragonAI>().Chase = true;
        }

        if (guardChalice)
        {
            transform.LookAt(chalicePosition);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }
    }
}
