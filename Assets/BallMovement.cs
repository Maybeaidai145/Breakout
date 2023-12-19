using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{
    Rigidbody Ball;

    
    // Start is called before the first frame update
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        Ball.AddForce(new Vector3(0, -5, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = 10;
        Ball.velocity = Ball.velocity.normalized * Speed;

        if (transform.position.y <= -6)
        {
            transform.position = new Vector3(0, 0, 0);
            Ball.AddForce(new Vector3(0, -3, 0), ForceMode.Impulse);
        }
        
    }
}
