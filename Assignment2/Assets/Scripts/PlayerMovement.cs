using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;
    private Rigidbody2D myRigidBody;
    private Vector2 change;
    private Animator Animator;

    // Start is called before the first frame update
    void Start()
    {
        
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        myRigidBody.velocity = new Vector2(change.x * speed, change.y * speed);
       
    }
}
