using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float m_smoothTimeX;
    public float m_smoothTimeY;
    private GameObject player;
    private GameObject boat;

    private Vector2 velocity;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        boat = GameObject.FindGameObjectWithTag("Boat");
    }

    // Function originally written by 'Gucio Devs'
    public void FixedUpdate()
    {
        var player = GameObject.Find("Player");
        var movement = player.GetComponent<Player>();

        if (movement.isBoat == false)
        {
            float positionX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x,
                m_smoothTimeX);
            float positionY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y,
                m_smoothTimeY);

            transform.position = new Vector3(positionX, positionY, transform.position.z);
        }

        else
        {
            float positionX = Mathf.SmoothDamp(transform.position.x, boat.transform.position.x, ref velocity.x,
          m_smoothTimeX);
            float positionY = Mathf.SmoothDamp(transform.position.y, boat.transform.position.y, ref velocity.y,
                m_smoothTimeY);

            transform.position = new Vector3(positionX, positionY, transform.position.z);
        }
    }
}