using UnityEngine;
using System.Collections;

public class CounterGUI : MonoBehaviour {

	private PlayerControls pcp;
	public GameObject go;
	private string message;

	// Use this for initialization
	void Start () {
		pcp = (PlayerControls)go.GetComponent (typeof(PlayerControls));
		message = "";
	}
	
	// Update is called once per frame
	void Update () {
		message = pcp.GetCount ().ToString();

	}

	void OnGUI()
	{
		GUI.Box (new Rect (400, 0, 50, 50), message);

	}
}
