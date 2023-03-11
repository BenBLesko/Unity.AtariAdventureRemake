using UnityEngine;

public class GreenDragonHealth : MonoBehaviour
{
    public int MaxDragonHealth;
    public int CurrentDragonHealth;

    public bool GreenDragonDead;

    public GameObject thisDragon;
    public GameObject thisDragonSkeleton;
    public GameObject thisDragonHead;
    public GameObject thisDragonBiteAttack;

    public AudioSource DragonDiesSFX;
    MeshFilter Mesh;

    void Start()
    {
        CurrentDragonHealth = MaxDragonHealth;
    }

    public void TakeDamage(int damage)
    {
        CurrentDragonHealth -= damage;

        if (CurrentDragonHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        GreenDragonDead = true;

        DragonDiesSFX.Play();

        Mesh = thisDragonSkeleton.GetComponent<MeshFilter>();
        Mesh.sharedMesh = Resources.Load<Mesh>("DeadDragon");

        thisDragonSkeleton.GetComponent<Collider>().isTrigger = false;
        thisDragonHead.GetComponent<Collider>().isTrigger = false;
        thisDragonBiteAttack.GetComponent<Collider>().enabled = false;
        thisDragon.GetComponent<DragonAI>().enabled = false;
        thisDragon.GetComponent<GuardsBlackKey>().enabled = false;
        
        if (thisDragon.GetComponent<GuardsMagnet>().enabled == true)
        {
            thisDragon.GetComponent<GuardsMagnet>().enabled = false;
        }
    }
}
