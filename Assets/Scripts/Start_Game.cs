using UnityEngine;
using System.Collections;

public class Start_Game : MonoBehaviour {

	public GameObject pPlayer;
	public GameObject pPanel;

	public void StartWhenClicked()
	{
		if (pPlayer.active == false) {
		pPlayer.SetActive(true);
		pPanel.SetActive(false);
			Cursor.visible = false;
		}
	}



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	private void Update () {
		
	}
}
