using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour
{
    /// <summary>
    /// Class which scrolls the background 
    /// Attached to player controller which determines when the player is moving 
    /// </summary>

    public float m_speed;
    public static Scroll current;

    float pos = 0;
    Renderer m_renderer;

    // Use this for initialization
    void Start()
    {
        m_renderer = GetComponent<Renderer>();
        current = this;
    }

    // Function which states if player is moving, scroll
    public void Go()
    {
        pos += m_speed;
        if (pos > 1.0f)
        {
            pos -= 1.0f;
        }
        m_renderer.material.mainTextureOffset = new Vector2(pos, 0);

    }
}
