using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
//using System.Runtime.Hosting;

public class menuScript : MonoBehaviour {

	public void triggerMenu(int trigger) {
		switch (trigger) {
		case(0) :
			SceneManager.LoadScene("gameScene");
			break;
		case(1) :
			Application.Quit();
			break;
		case(2) :
			SceneManager.LoadScene("Menu2");
			break;
		case(3) :
			SceneManager.LoadScene("MenuPrincipal");
			break;
		case(4) :
			SceneManager.LoadScene("SampleScene");
			break;
		case(5) :
				SceneManager.LoadScene("menuScene");
				break;
		}
	}
}
