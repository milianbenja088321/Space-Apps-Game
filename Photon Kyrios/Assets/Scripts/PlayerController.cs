using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public int jumpspeed;
    public bool canJump;
    public Rigidbody self;
    public float timer = 5;
    void Start()
    {
        speed = 5f;
        jumpspeed = 3;
        canJump = false;
    }


    void Update()
    {
        transform.Translate(0f, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }

        if (canJump)
        {
            canJump = false;
            self.AddForce(0, jumpspeed, 0, ForceMode.Impulse);
        }

        if (!canJump)
        {

        timer -= Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space) && timer <= 0)
        {
            canJump = true;
            timer += 5;
        }
    }

}
