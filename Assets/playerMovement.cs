using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody paddle;

    void Start()
    {
        transform.position = new Vector3(0, -6, 0);
        paddle = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            paddle.AddForce(new Vector3(-2, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            paddle.AddForce(new Vector3(2, 0, 0), ForceMode.Impulse);
        }

    }
}
