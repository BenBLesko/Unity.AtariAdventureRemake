using System.Collections;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int MaxPlayerHealth;
    public int CurrentPlayerHealth;

    public GameObject Player;
    public GameObject respawn;

    public GameObject GreenDragon;
    public GameObject GreenDragonSkeleton;
    public GameObject GreenDragonHead;
    public GameObject GreenDragonBiteAttack;
    public GameObject PlayerDeadByGreenDragon;
    
    public GameObject YellowDragon;
    public GameObject YellowDragonSkeleton;
    public GameObject YellowDragonHead;
    public GameObject YellowDragonBiteAttack;
    public GameObject PlayerDeadByYellowDragon;

    // public GameObject RedDragon;
    // public GameObject RedDragonSkeleton;
    // public GameObject RedDragonHead;
    // public GameObject RedDragonBiteAttack;
    // public GameObject PlayerDeadByRedDragon;

    MeshFilter Mesh;

    public AudioSource PlayerDiesSFX;

    void Start()
    {
        CurrentPlayerHealth = MaxPlayerHealth;
    }

    public void PlayerDiedByYellowSword()
    {
        {
            StartCoroutine(Respawn());
        }

        IEnumerator Respawn()
        {

            PlayerDiesSFX.Play();
            Player.GetComponent<PlayerLocomotion>().enabled = false;
            Player.GetComponent<CharacterController>().enabled = false;

            if (Player.GetComponent<PlayerInventory>().currentItem != null)
            {
                Player.GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
                Player.GetComponent<PlayerInventory>().currentItem = null;
            }

            yield return new WaitForSeconds(1.5f);

            Player.GetComponent<PlayerLocomotion>().enabled = true;
            Player.GetComponent<CharacterController>().enabled = true;

            Mesh = GreenDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            if (GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead == true)
            {
                GreenDragon.GetComponent<DragonAI>().enabled = true;
                GreenDragon.GetComponent<GuardsBlackKey>().enabled = true;
                GreenDragonSkeleton.GetComponent<Collider>().enabled = true;
                GreenDragonSkeleton.GetComponent<Collider>().isTrigger = true;
                GreenDragonHead.GetComponent<Collider>().isTrigger = true;
                GreenDragonBiteAttack.GetComponent<Collider>().enabled = true;
            }

            GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead = false;

            Mesh = YellowDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            if (YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead == true)
            {
                YellowDragon.GetComponent<DragonAI>().enabled = true;
                YellowDragonSkeleton.GetComponent<Collider>().enabled = true;
                YellowDragonSkeleton.GetComponent<Collider>().isTrigger = true;
                YellowDragonHead.GetComponent<Collider>().isTrigger = true;
                YellowDragonBiteAttack.GetComponent<Collider>().enabled = true;
            }

            YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead = false;

            // Mesh = RedDragonSkeleton.GetComponent<MeshFilter>();
            // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            // if (RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead == true)
            // {
            // RedDragon.GetComponent<DragonAI>().enabled = true;
            // RedDragonSkeleton.GetComponent<Collider>().enabled = true;
            // RedDragonSkeleton.GetComponent<Collider>().isTrigger = true;
            // RedDragonHead.GetComponent<Collider>().isTrigger = true;
            // RedDragonBiteAttack.GetComponent<Collider>().enabled = true;
            //}

            // RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead = false;

            yield return new WaitForSeconds(0.25f);

            if (Player.GetComponent<PlayerInventory>().currentItem != null)
            {
                Player.GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
                Player.GetComponent<PlayerInventory>().currentItem = null;
            }

            Player.transform.position = respawn.transform.position;
        }
    }

    public void GreenDragonCauseDamage(int damage)
    {
        CurrentPlayerHealth -= damage;

        if (CurrentPlayerHealth <= 0)
        {
            PlayerDiedByGreenDragon();
        }
    }  
    
    void PlayerDiedByGreenDragon()
    {
        {
            StartCoroutine(Respawn());
        }

        IEnumerator Respawn()
        {
            PlayerDiesSFX.Play();
            GetComponent<Collider>().enabled = false;
            GetComponent<PlayerLocomotion>().enabled = false;
            GetComponent<CharacterController>().enabled = false;
           
            if (GetComponent<PlayerInventory>().currentItem != null)
            {
                GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
            }
            
            GreenDragon.GetComponent<DragonAI>().enabled = false;
            GreenDragonSkeleton.GetComponent<Collider>().enabled = false;
            Player.transform.position = PlayerDeadByGreenDragon.transform.position;
            
            yield return new WaitForSeconds(1.5f);

            GetComponent<Collider>().enabled = true;
            GetComponent<PlayerLocomotion>().enabled = true;
            GetComponent<CharacterController>().enabled = true;
            Player.transform.position = respawn.transform.position;
            CurrentPlayerHealth = MaxPlayerHealth;

            yield return new WaitForSeconds(0.25f);

            Mesh = GreenDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");
            GreenDragon.GetComponent<DragonAI>().enabled = true;
            GreenDragonSkeleton.GetComponent<Collider>().enabled = true;
            GreenDragonSkeleton.GetComponent<Collider>().isTrigger = true;

            Mesh = YellowDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");
            
            if (YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead == true)
            {
                YellowDragon.GetComponent<DragonAI>().enabled = true;
                YellowDragonSkeleton.GetComponent<Collider>().enabled = true;
                YellowDragonSkeleton.GetComponent<Collider>().isTrigger = true;
                YellowDragonHead.GetComponent<Collider>().isTrigger = true;
                YellowDragonBiteAttack.GetComponent<Collider>().enabled = true;
            }

            yield return new WaitForSeconds(0.25f);

            YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead = false;

            // Mesh = RedDragonSkeleton.GetComponent<MeshFilter>();
            // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            // if (RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead == true)
            // {
            // RedDragon.GetComponent<DragonAI>().enabled = true;
            // RedDragonSkeleton.GetComponent<Collider>().enabled = true;
            // RedDragon.GetComponent<Collider>().isTrigger = true;
            // RedDragonHead.GetComponent<Collider>().isTrigger = true;
            // RedDragonBiteAttack.GetComponent<Collider>().enabled = true;
            // }

            // yield return new WaitForSeconds(0.25f);

            // RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead = false;
        }
    }

    public void YellowDragonCauseDamage(int damage)
    {
        CurrentPlayerHealth -= damage;

        if (CurrentPlayerHealth <= 0)
        {
            PlayerDiedByYellowDragon();
        }
    }

    void PlayerDiedByYellowDragon()
    {
        {
            StartCoroutine(Respawn());
        }

        IEnumerator Respawn()
        {
            PlayerDiesSFX.Play();
            GetComponent<Collider>().enabled = false;
            GetComponent<PlayerLocomotion>().enabled = false;
            GetComponent<CharacterController>().enabled = false;

            if (GetComponent<PlayerInventory>().currentItem != null)
            {
                GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
            }

            YellowDragon.GetComponent<DragonAI>().enabled = false;
            YellowDragonSkeleton.GetComponent<Collider>().enabled = false;
            Player.transform.position = PlayerDeadByYellowDragon.transform.position;

            yield return new WaitForSeconds(1.5f);

            GetComponent<Collider>().enabled = true;
            GetComponent<PlayerLocomotion>().enabled = true;
            GetComponent<CharacterController>().enabled = true;
            Player.transform.position = respawn.transform.position;
            CurrentPlayerHealth = MaxPlayerHealth;
            
            yield return new WaitForSeconds(0.25f);

            Mesh = YellowDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");
            YellowDragon.GetComponent<DragonAI>().enabled = true;
            YellowDragonSkeleton.GetComponent<Collider>().enabled = true;
            YellowDragonSkeleton.GetComponent<Collider>().isTrigger = true;

            Mesh = GreenDragonSkeleton.GetComponent<MeshFilter>();
            Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            if (GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead == true)
            {
                GreenDragon.GetComponent<DragonAI>().enabled = true;
                GreenDragon.GetComponent<GuardsBlackKey>().enabled = true;
                GreenDragonSkeleton.GetComponent<Collider>().enabled = true;
                GreenDragonSkeleton.GetComponent<Collider>().isTrigger = true;
                GreenDragonHead.GetComponent<Collider>().isTrigger = true;
                GreenDragonBiteAttack.GetComponent<Collider>().enabled = true;
            }

            yield return new WaitForSeconds(0.25f);

            GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead = false;

            // Mesh = RedDragonSkeleton.GetComponent<MeshFilter>();
            // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

            // if (RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead == true)
            // {
            // RedDragon.GetComponent<DragonAI>().enabled = true;
            // RedDragonSkeleton.GetComponent<Collider>().enabled = true;
            // RedDragon.GetComponent<Collider>().isTrigger = true;
            // RedDragonHead.GetComponent<Collider>().isTrigger = true;
            // RedDragonBiteAttack.GetComponent<Collider>().enabled = true;
            // }

            // yield return new WaitForSeconds(0.25f);

            // RedDragonSkeleton.GetComponent<RedDragonHealth>().RedDragonDead = false;
        }
    }

    // public void RedDragonCauseDamage(int damage)
    // {
    // CurrentPlayerHealth -= damage;

    // if (CurrentPlayerHealth <= 0)
    // {
    // PlayerDiedByRedDragon();
    // }
    // }

    // void PlayerDiedByRedDragon()
    // {
    // {
    // StartCoroutine(Respawn());
    // }

    // IEnumerator Respawn()
    // {

    // PlayerDiesSFX.Play();
    // GetComponent<Collider>().enabled = false;
    // GetComponent<PlayerLocomotion>().enabled = false;
    // GetComponent<CharacterController>().enabled = false;
    // if (GetComponent<PlayerInventory>().currentItem != null)
    // {
    // GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
    // }
    // RedDragon.GetComponent<DragonAI>().enabled = false;
    // RedDragonSkeleton.GetComponent<Collider>().enabled = false;
    // Player.transform.position = PlayerDeadByRedDragon.transform.position;

    // yield return new WaitForSeconds(1.5f);

    // GetComponent<Collider>().enabled = true;
    // GetComponent<PlayerLocomotion>().enabled = true;
    // GetComponent<CharacterController>().enabled = true;
    // Player.transform.position = respawn.transform.position;
    // CurrentPlayerHealth = MaxPlayerHealth;

    // yield return new WaitForSeconds(0.25f);

    // Mesh = RedDragonSkeleton.GetComponent<MeshFilter>();
    // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");
    // RedDragon.GetComponent<DragonAI>().enabled = true;
    // RedDragonSkeleton.GetComponent<Collider>().enabled = true;
    // RedDragonSkeleton.GetComponent<Collider>().isTrigger = true;

    // Mesh = GreenDragonSkeleton.GetComponent<MeshFilter>();
    // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

    // if (GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead == true)
    // {
    // GreenDragon.GetComponent<DragonAI>().enabled = true;
    // GreenDragonSkeleton.GetComponent<Collider>().enabled = true;
    // GreenDragon.GetComponent<Collider>().isTrigger = true;
    // GreenDragonHead.GetComponent<Collider>().isTrigger = true;
    // GreenDragonBiteAttack.GetComponent<Collider>().enabled = true;
    // }

    // yield return new WaitForSeconds(0.25f);

    // GreenDragonSkeleton.GetComponent<GreenDragonHealth>().GreenDragonDead = false;

    // Mesh = YellowDragonSkeleton.GetComponent<MeshFilter>();
    // Mesh.sharedMesh = Resources.Load<Mesh>("MovingDragon");

    // if (YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead == true)
    // {
    // YellowDragon.GetComponent<DragonAI>().enabled = true;
    // YellowDragonSkeleton.GetComponent<Collider>().enabled = true;
    // YellowDragonSkeleton.GetComponent<Collider>().isTrigger = true;
    // YellowDragonHead.GetComponent<Collider>().isTrigger = true;
    // YellowDragonBiteAttack.GetComponent<Collider>().enabled = true;
    // }

    // yield return new WaitForSeconds(0.25f);

    // YellowDragonSkeleton.GetComponent<YellowDragonHealth>().YellowDragonDead = false;
}
