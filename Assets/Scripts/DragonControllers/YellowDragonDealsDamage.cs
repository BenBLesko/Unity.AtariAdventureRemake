using UnityEngine;

public class YellowDragonDealsDamage : MonoBehaviour
{
    public GameObject Player;

    public int _DragonDamageValue;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            other.GetComponent<PlayerHealth>().YellowDragonCauseDamage(_DragonDamageValue);
        }
    }
}
