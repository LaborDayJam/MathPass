using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{

	public GameObject[] panels;

	private int 		menuState = 0;
	// Use this for initialization
	void Start () 
	{
		panels[menuState].SetActive(true);
	}
	private void TurnOffPanels()
	{
		for(int i = 0; i < panels.Length; i++)
			panels[i].SetActive(false);
	}

	#region MainPanels
	public void OnStart()
	{
		// start networking code here;
	}

	public void OnOptions()
	{
		panels[0].SetActive(false);
		panels[2].SetActive(true);
		menuState = 2;
	}

	public void OnExit()
	{
		panels[0].SetActive(false);
		panels[3].SetActive(true);
		menuState = 3;
		// save info here 
	}


	public void OnBack()
	{
		if(menuState < 4)
		{
			menuState = 0;
			TurnOffPanels();
			panels[0].SetActive(true);
		}
		else if(menuState >= 4)
		{
			menuState = 1;
			TurnOffPanels();
			panels[1].SetActive(true);

		}
	}
	#endregion
	#region StartPanel
	public void RegGame()
	{
		// search for a network game;
	}

	public void MiniGame()
	{
		//play a mini game
	}
	#endregion
	#region OptionsPanel
	public void OnSettings()
	{
		menuState = 3;
		TurnOffPanels();
		panels[menuState].SetActive(true);
	}

	public void OnStats()
	{
		menuState = 4;
		TurnOffPanels();
		panels[menuState].SetActive(true);
	}
	#endregion
	#region ExitPanel
	public void OnExit2()
	{
		Application.Quit();
	}
	#endregion
}
