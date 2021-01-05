using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour 
{
	public void StartButton(string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);	
	}

	public void ExitButton()
	{
		Application.Quit ();
	}
	//pause gombot is implemetálni kell!
}
