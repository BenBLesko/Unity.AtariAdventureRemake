using System.Collections;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject Chalice;
    
    public GameObject Wall_N;
    public GameObject Wall_E;
    public GameObject Wall_W;
    public GameObject Wall_S1;
    public GameObject Wall_S2;
    
    public GameObject Player;

    public Transform teleportPlayer;

    public Material White;
    public Material LightYellow;
    public Material Yellow;
    public Material Orange;
    public Material Magenta;
    public Material Purple;
    public Material LightBlue;
    public Material Blue;
    public Material LighterGreen;
    public Material LightGreen;
    public Material Green;
    public Material DarkGreen;

    public AudioSource Win;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Chalice)
        {
            Player.transform.position = teleportPlayer.transform.position;
            Player.GetComponent<PlayerLocomotion>().enabled = false;
            Player.GetComponent<RespawnPlayer>().enabled = false;
            Win.Play();
            StartCoroutine("WinColours");
        }
    }
    IEnumerator WinColours()
    {
        while (true)
        {   
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = White;
            Player.GetComponent<MeshRenderer>().material = White;
            Wall_N.GetComponent<MeshRenderer>().material = White;
            Wall_E.GetComponent<MeshRenderer>().material = White;
            Wall_W.GetComponent<MeshRenderer>().material = White;
            Wall_S1.GetComponent<MeshRenderer>().material = White;
            Wall_S2.GetComponent<MeshRenderer>().material = White;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = LightYellow;
            Player.GetComponent<MeshRenderer>().material = LightYellow;
            Wall_N.GetComponent<MeshRenderer>().material = LightYellow;
            Wall_E.GetComponent<MeshRenderer>().material = LightYellow;
            Wall_W.GetComponent<MeshRenderer>().material = LightYellow;
            Wall_S1.GetComponent<MeshRenderer>().material = LightYellow;
            Wall_S2.GetComponent<MeshRenderer>().material = LightYellow;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Yellow;
            Player.GetComponent<MeshRenderer>().material = Yellow;
            Wall_N.GetComponent<MeshRenderer>().material = Yellow;
            Wall_E.GetComponent<MeshRenderer>().material = Yellow;
            Wall_W.GetComponent<MeshRenderer>().material = Yellow;
            Wall_S1.GetComponent<MeshRenderer>().material = Yellow;
            Wall_S2.GetComponent<MeshRenderer>().material = Yellow;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Orange;
            Player.GetComponent<MeshRenderer>().material = Orange;
            Wall_N.GetComponent<MeshRenderer>().material = Orange;
            Wall_E.GetComponent<MeshRenderer>().material = Orange;
            Wall_W.GetComponent<MeshRenderer>().material = Orange;
            Wall_S1.GetComponent<MeshRenderer>().material = Orange;
            Wall_S2.GetComponent<MeshRenderer>().material = Orange;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Magenta;
            Player.GetComponent<MeshRenderer>().material = Magenta;
            Wall_N.GetComponent<MeshRenderer>().material = Magenta;
            Wall_E.GetComponent<MeshRenderer>().material = Magenta;
            Wall_W.GetComponent<MeshRenderer>().material = Magenta;
            Wall_S1.GetComponent<MeshRenderer>().material = Magenta;
            Wall_S2.GetComponent<MeshRenderer>().material = Magenta;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Purple;
            Player.GetComponent<MeshRenderer>().material = Purple;
            Wall_N.GetComponent<MeshRenderer>().material = Purple;
            Wall_E.GetComponent<MeshRenderer>().material = Purple;
            Wall_W.GetComponent<MeshRenderer>().material = Purple;
            Wall_S1.GetComponent<MeshRenderer>().material = Purple;
            Wall_S2.GetComponent<MeshRenderer>().material = Purple;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = LightBlue;
            Player.GetComponent<MeshRenderer>().material = LightBlue;
            Wall_N.GetComponent<MeshRenderer>().material = LightBlue;
            Wall_E.GetComponent<MeshRenderer>().material = LightBlue;
            Wall_W.GetComponent<MeshRenderer>().material = LightBlue;
            Wall_S1.GetComponent<MeshRenderer>().material = LightBlue;
            Wall_S2.GetComponent<MeshRenderer>().material = LightBlue;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Blue;
            Player.GetComponent<MeshRenderer>().material = Blue;
            Wall_N.GetComponent<MeshRenderer>().material = Blue;
            Wall_E.GetComponent<MeshRenderer>().material = Blue;
            Wall_W.GetComponent<MeshRenderer>().material = Blue;
            Wall_S1.GetComponent<MeshRenderer>().material = Blue;
            Wall_S2.GetComponent<MeshRenderer>().material = Blue;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = LighterGreen;
            Player.GetComponent<MeshRenderer>().material = LighterGreen;
            Wall_N.GetComponent<MeshRenderer>().material = LighterGreen;
            Wall_E.GetComponent<MeshRenderer>().material = LighterGreen;
            Wall_W.GetComponent<MeshRenderer>().material = LighterGreen;
            Wall_S1.GetComponent<MeshRenderer>().material = LighterGreen;
            Wall_S2.GetComponent<MeshRenderer>().material = LighterGreen;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = LightGreen;
            Player.GetComponent<MeshRenderer>().material = LightGreen;
            Wall_N.GetComponent<MeshRenderer>().material = LightGreen;
            Wall_E.GetComponent<MeshRenderer>().material = LightGreen;
            Wall_W.GetComponent<MeshRenderer>().material = LightGreen;
            Wall_S1.GetComponent<MeshRenderer>().material = LightGreen;
            Wall_S2.GetComponent<MeshRenderer>().material = LightGreen;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = Green;
            Player.GetComponent<MeshRenderer>().material = Green;
            Wall_N.GetComponent<MeshRenderer>().material = Green;
            Wall_E.GetComponent<MeshRenderer>().material = Green;
            Wall_W.GetComponent<MeshRenderer>().material = Green;
            Wall_S1.GetComponent<MeshRenderer>().material = Green;
            Wall_S2.GetComponent<MeshRenderer>().material = Green;
            yield return new WaitForSeconds(0.25f);
            Chalice.GetComponent<MeshRenderer>().material = DarkGreen;
            Player.GetComponent<MeshRenderer>().material = DarkGreen;
            Wall_N.GetComponent<MeshRenderer>().material = DarkGreen;
            Wall_E.GetComponent<MeshRenderer>().material = DarkGreen;
            Wall_W.GetComponent<MeshRenderer>().material = DarkGreen;
            Wall_S1.GetComponent<MeshRenderer>().material = DarkGreen;
            Wall_S2.GetComponent<MeshRenderer>().material = DarkGreen;
            yield return new WaitForSeconds(0.25f);
        }
    }
}
