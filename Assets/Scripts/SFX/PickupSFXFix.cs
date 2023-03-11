using UnityEngine;

public class PickupSFXFix : MonoBehaviour
{
    public AudioSource PickUpSFX;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pickup")
        {
            PickUpSFX.Play();
        }
    }
}
