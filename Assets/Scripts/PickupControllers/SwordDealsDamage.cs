using System.Collections;
using UnityEngine;

public class SwordDealsDamage : MonoBehaviour
{
    public GameObject Player;
    public GameObject respawn;

    public GameObject GreenDragon;
    public GameObject GreenDragonSkeleton;
    public GameObject GreenDragonHead;
    public GameObject GreenDragonBiteAttack;
    public GameObject YellowDragon;
    public GameObject YellowDragonSkeleton;
    public GameObject YellowDragonHead;
    public GameObject YellowDragonBiteAttack;
    // public GameObject RedDragon;
    // public GameObject RedDragonSkeleton;
    // public GameObject RedDragonHead;
    // public GameObject RedDragonBiteAttack;

    public int DragonDamageValue;

    MeshFilter Mesh;

    public AudioSource PlayerDiesSFX;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.GetComponent<PlayerHealth>().PlayerDiedByYellowSword();
        }

        if (other.gameObject == GreenDragonSkeleton)
        {
            if (GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead == false && GreenDragon.GetComponent<DragonAI>().isAttacking == false)
                {
                    other.GetComponent<GreenDragonHealth>().TakeDamage(DragonDamageValue);
                }
            return;
            
        }

        if (other.gameObject == YellowDragonSkeleton)
        {
            if (YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead == false && YellowDragon.GetComponent<DragonAI>().isAttacking == false)
            {
                other.GetComponent<YellowDragonHealth>().TakeDamage(DragonDamageValue);
            }
            return;
        }

        // if (other.gameObject == RedDragonSkeleton)
        // {
        // if (RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead == false && RedDragon.GetComponent<DragonAI>().isAttacking == false)
        // {
        // other.GetComponent<RedDragonHealth>().TakeDamage(DragonDamageValue);
        // }
        // return;
        // }
    }
}
