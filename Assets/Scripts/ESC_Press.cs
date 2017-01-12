using UnityEngine;
using System.Collections;

public class ESC_Press : MonoBehaviour {

	public GameObject pPlayer;
	public GameObject pPanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("escape")) {
			pPanel.SetActive (true);
			pPlayer.SetActive (false);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		}

	}
}
