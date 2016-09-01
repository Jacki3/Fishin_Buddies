using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.Assertions.Comparers;

public class Player : MonoBehaviour
{

    public float m_speed;
    public bool isBoat;

    public float Hmove;
    public float Vmove;

    bool facingRight = false;

    void Start () {
	
	}
	
	public void Update ()
	{

	    var boat = GameObject.Find("boat");
	    var movement = boat.GetComponent<Boat>();

	    if (isBoat)
	    {
            movement.Update();	        
	    }
	    else
	    {

	         Hmove = Input.GetAxis("Horizontal");
	         Vmove = Input.GetAxis("Vertical");

	        GetComponent<Rigidbody2D>().velocity = new Vector2(Hmove*m_speed, Vmove*m_speed);
	    }

        if (Hmove < 0 && !facingRight)
        {
            Flip();
        }
        else if (Hmove > 0 && facingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    public void Boat()
    {
        isBoat = !isBoat;
    }
}
