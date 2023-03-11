using System.Collections;
using UnityEngine;

public class DragonAI : MonoBehaviour
{
    public Transform player;

    public bool Chase;

    public float Speed;
    public float DistanceToThePlayer;
    public float MinDistanceToThePlayer;
    public float MaxDistanceToThePlayer;

    public GameObject thisDragon;
    public GameObject thisDragonSkeleton;
    public GameObject thisDragonHead;

    public GameObject Player;

    public bool isAttacking;

    public AudioSource DragonDealsDamageSFX;

    MeshFilter Mesh;

    void Update()
    {
        DistanceToThePlayer = Vector3.Distance(transform.position, player.position);
        
        if (DistanceToThePlayer > MinDistanceToThePlayer && DistanceToThePlayer < MaxDistanceToThePlayer)
        {
            Chase = true;
        }
        if (Chase && MinDistanceToThePlayer < DistanceToThePlayer)
        {
            transform.LookAt(player);
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);

            if (transform.position.x > player.position.x)
            {
                transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
            }
            else
            {
                transform.rotation = Quaternion.Euler(new Vector3(-90, 0, 180));
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        {
            StartCoroutine(Animations());
        }

        IEnumerator Animations()
        {
            if (other.gameObject == Player)
            {
                DragonDealsDamageSFX.Play();

                Mesh = thisDragonSkeleton.GetComponent<MeshFilter>();
                Mesh.sharedMesh = Resources.Load<Mesh>("AttackingDragon");
                isAttacking = true;
                thisDragon.GetComponent<DragonAI>().enabled = false;
                thisDragonSkeleton.GetComponent<Collider>().isTrigger = false;
                thisDragonHead.GetComponent<Collider>().isTrigger = false;

                yield return new WaitForSeconds(1.5f);

                Mesh = thisDragonSkeleton.GetComponent<MeshFilter>();
                Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");
                isAttacking = false;
                thisDragon.GetComponent<DragonAI>().enabled = true;
                thisDragonSkeleton.GetComponent<Collider>().isTrigger = true;
                thisDragonHead.GetComponent<Collider>().isTrigger = true;

                yield return new WaitForSeconds(0.25f);
            }
        }
    }
}
