using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadShop : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log("Load the shop scene here...");
		Debug.Log(SceneManager.GetActiveScene().name);
		Debug.Log(coll.contacts[1].otherCollider.name);
		if (SceneManager.GetActiveScene().name == "Shop")
		{
			SceneManager.LoadScene("Dev_James");
			return;
		}
		if (coll.contacts[1].otherCollider.name == "boat1")
		{
			SceneManager.LoadScene("Boat");
			return;
		}
		if (coll.contacts[1].otherCollider.name == "Bus")
		{
			SceneManager.LoadScene("Shop");
		}
	}
}
