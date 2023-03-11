using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    public GameObject Player;
    public GameObject Respawn;

    public AudioSource PlayerDiesSFX;

    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            if (GetComponent<PlayerInventory>().currentItem != null)
            {
                GetComponent<PlayerInventory>().currentItem.gameObject.transform.SetParent(null);
                GetComponent<PlayerInventory>().currentItem = null;
            }

            if (GetComponent<PlayerLocomotion>().enabled == false)
            {
                GetComponent<PlayerLocomotion>().enabled = true;
            }

            PlayerDiesSFX.Play();
            Player.transform.position = Respawn.transform.position;
        }
    }
}
