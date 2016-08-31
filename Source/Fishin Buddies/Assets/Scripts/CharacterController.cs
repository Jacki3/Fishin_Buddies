using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = false;

    public GameObject m_background;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float move = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, 0);

        if (move > 0 && !facingRight)
		{
			Flip();
		}
		else if(move < 0 && facingRight) {
			Flip();
        }

    }

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
