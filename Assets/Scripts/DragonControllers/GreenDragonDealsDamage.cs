using UnityEngine;

public class GreenDragonDealsDamage : MonoBehaviour
{
    public GameObject Player;

    public int _DragonDamageValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            other.GetComponent<PlayerHealth>().GreenDragonCauseDamage(_DragonDamageValue);
        }
    }
}
