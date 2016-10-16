using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; //Shows up in the editor if public

	private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Called before performing physics calculation
    void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}
