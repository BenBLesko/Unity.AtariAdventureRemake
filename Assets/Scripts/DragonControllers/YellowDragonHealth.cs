using UnityEngine;

public class YellowDragonHealth : MonoBehaviour
{
    public int MaxDragonHealth;
    public int CurrentDragonHealth;

    public bool YellowDragonDead;

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
        YellowDragonDead = true;

        DragonDiesSFX.Play();

        Mesh = thisDragonSkeleton.GetComponent<MeshFilter>();
        Mesh.sharedMesh = Resources.Load<Mesh>("DeadDragon");

        thisDragonSkeleton.GetComponent<Collider>().isTrigger = false;
        thisDragonHead.GetComponent<Collider>().isTrigger = false;
        thisDragonBiteAttack.GetComponent<Collider>().enabled = false;
        thisDragon.GetComponent<DragonAI>().enabled = false;
        thisDragon.GetComponent<YellowDragonFlees>().enabled = false;
        
        if (thisDragon.GetComponent<GuardsChalice>().enabled == true)
        {
            thisDragon.GetComponent<GuardsChalice>().guardChalice = false;
        }
    }
}
