using System.Collections;
using UnityEngine;

public class ChangeCreatorsColour : MonoBehaviour
{
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

    public GameObject Creators;

    void Awake()
    {
        StartCoroutine("_EasterEgg");
    }

    IEnumerator _EasterEgg()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = White;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = LightYellow;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Yellow;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Orange;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Magenta;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Purple;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = LightBlue;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Blue;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = LighterGreen;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = LightGreen;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = Green;
            yield return new WaitForSeconds(0.25f);
            Creators.GetComponent<MeshRenderer>().material = DarkGreen;
            yield return new WaitForSeconds(0.25f);
        }
    }
}