using UnityEngine;

public class Gravity : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 4;
    public float m_JumpMultiplier = 2;


    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
}

    void Update()
    {
        if (Input.GetKey("space")) {

            this.m_Rigidbody.AddForce(transform.up * this.m_Thrust * this.m_JumpMultiplier);
        
        }

        if(Input.GetKey("right"))
        {
            this.m_Rigidbody.AddForce(transform.right * this.m_Thrust);
        }

        if (Input.GetKey("left"))
        {
            this.m_Rigidbody.AddForce(-transform.right * this.m_Thrust);
        }
    }
}
