using UnityEngine;
using System.Collections;

public class Exit_Game : MonoBehaviour {


	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit ();
		#endif
	}
}
