// using UnityEngine;

// public class RedDragonHealth : MonoBehaviour
// {
// public int MaxDragonHealth;
// public int CurrentDragonHealth;

// public bool RedDragonDead;

// public GameObject thisDragon;
// public GameObject thisDragonSkeleton;
// public GameObject thisDragonHead;
// public GameObject thisDragonBiteAttack;
// public AudioSource DragonDiesSFX;
// MeshFilter Mesh;

// void Start()
// {
// CurrentDragonHealth = MaxDragonHealth;
// }

// public void TakeDamage(int damage)
// {
// CurrentDragonHealth -= damage;

// if (CurrentDragonHealth <= 0)
// {
// Die();
// }
// }

// void Die()
// {
// RedDragonDead = true;

// DragonDiesSFX.Play();

// Mesh = thisDragonSkeleton.GetComponent<MeshFilter>();
// Mesh.sharedMesh = Resources.Load<Mesh>("DeadDragon");

// thisDragonSkeleton.GetComponent<Collider>().isTrigger = false;
// thisDragonHead.GetComponent<Collider>().isTrigger = false;
// thisDragonBiteAttack.GetComponent<Collider>().enabled = false;
// thisDragon.GetComponent<DragonAI>().enabled = false;
// }
// }
