using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(force * speed);

    }
}
