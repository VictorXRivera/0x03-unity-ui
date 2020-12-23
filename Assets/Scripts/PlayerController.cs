using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 500f;

    void Start()
    {
        Debug.Log("Movement");
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("d"))
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("a"))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey("w"))
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        
        if (Input.GetKey("s"))
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(0, 0, -500 * Time.deltaTime);
    }
}