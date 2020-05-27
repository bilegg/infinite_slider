using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce;
    public float turnForce;

    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement
        if(Input.GetKey("a")){
            rb.AddForce((-1) * turnForce, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(turnForce, 0, 0, ForceMode.VelocityChange);
        }

        rb.AddForce(0, 0, forwardForce);
    }
}
