using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			SceneManager.LoadScene("1st Variation");
		}

		if (Input.GetButtonDown("Fire2"))
		{
			Application.Quit();
		}
	}
}
