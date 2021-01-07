using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour 
{
	public bool isStart;
	public bool isQuit;
	public bool isPause;
	//void Start()
	//   {

	//   }
	public void StartButton(string newGameLevel)
	{
		SceneManager.LoadScene (newGameLevel);	
	}
	void OnMouseUp()
	{
		if (isQuit)
		{
			Application.Quit();
		}
		if (isStart)
		{
			SceneManager.LoadScene("2nd_fields");
			//Application.LoadLevel(Application.loadedLevel);
			//Application.LoadLevel(1);			
			//renderer.material.color = Color.cyan;
		}
	}
	public void ExitButton()
	{
		Application.Quit ();
	}
	//pause gombot is implemetálni kell!
}
