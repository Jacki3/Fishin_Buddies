using UnityEngine;
using System.Collections;

public class Boat : MonoBehaviour
{

    public float m_speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update ()
	{

	    var player = GameObject.Find("Player");
	    var movement = player.GetComponent<Player>();

	    float move = Input.GetAxis("Horizontal");

        if(movement.isBoat)
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * m_speed, 0);
        else
        {
            return;            
        }

	}
}
