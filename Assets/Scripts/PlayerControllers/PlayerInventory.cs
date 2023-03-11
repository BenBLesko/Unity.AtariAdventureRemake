using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Pickup currentItem;
    public Pickup CurrentItem { get { return currentItem; } }
    
    public AudioSource DropSFX;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Pickup")
        {
            var newItem = collision.gameObject.GetComponent<Pickup>();

            if (newItem == currentItem)
            {
                return;
            }
            else
            {
                PickUp(newItem);
            }
        }
    }

    public void PickUp(Pickup pickup)
    {
        if (currentItem == pickup)
        {
            return;
        }

        if (currentItem != null)
        {
            currentItem.gameObject.transform.SetParent(null);
        }

        currentItem = pickup;
        currentItem.gameObject.transform.SetParent(transform);
        currentItem.currentRoom = -1;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && currentItem != null)
        {
            currentItem.gameObject.transform.SetParent(null);
            currentItem = null;
            
            DropSFX.Play();
        }
    }
}
