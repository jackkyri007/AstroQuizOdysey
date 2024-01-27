using UnityEngine;

public class Gravity : MonoBehaviour
{


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey("space")) {

            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 7, 0);
        
        }
    }
}
