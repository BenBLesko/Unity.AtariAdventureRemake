using UnityEngine;

public class YellowDragonFlees : MonoBehaviour
{
    public Transform yellowKeyPosition;
    public Transform chalicePosition;

    public bool Flee;

    public float Speed;
    public float DistanceToTheYellowKey;
    public float DistanceToTheChalice;
    public float MinDistanceToTheChalice;
    public float MaxDistanceToTheYellowKey;

    void Start()
    {
        Flee = false;
    }

    void Update()
    {
        DistanceToTheYellowKey = Vector3.Distance(transform.position, yellowKeyPosition.position);
        DistanceToTheChalice = Vector3.Distance(transform.position, chalicePosition.position);

        if (DistanceToTheYellowKey < MaxDistanceToTheYellowKey)
        {
            Flee = true;
            GetComponent<DragonAI>().Chase = false;
        }
        if (DistanceToTheChalice < MinDistanceToTheChalice)
        {
            Flee = false;
            GetComponent<YellowDragonFlees>().enabled = false;
            GetComponent<DragonAI>().enabled = true;
            GetComponent<DragonAI>().Chase = false;
            GetComponent<GuardsChalice>().enabled = true;
            GetComponent<GuardsChalice>().guardChalice = true;
        }

        if (Flee)
        {
            transform.LookAt(chalicePosition);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
        }
    }
}
