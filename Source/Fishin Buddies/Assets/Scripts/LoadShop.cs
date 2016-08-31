using UnityEngine;
using System.Collections;

public class LoadShop : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Load the shop scene here...");
		Debug.Log(Application.loadedLevelName);
		if (Application.loadedLevelName == "Shop")
		{
			Application.LoadLevel("Dev_James");
			return;
		}
		if (Application.loadedLevelName == "Dev_James")
		{
			Application.LoadLevel("Boat");
			return;
		}
		Application.LoadLevel("Shop");
	}
}
