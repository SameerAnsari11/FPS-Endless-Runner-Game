
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float moveForce = 200f;
    public float forwardForce = 500f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame

    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-moveForce*Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(moveForce * Time.deltaTime, 0, 0);
        }
    }
}
