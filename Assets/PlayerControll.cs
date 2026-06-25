using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    public float movSpeed;
    float speedX, speedY;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        Move();
    }

    void FixedUpdate(){

    }

    void ProcessInputs(){
        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(speedX, speedY);
    }

    void Move(){
        rb.linearVelocity = new Vector2(moveDirection.x * movSpeed, moveDirection.y * movSpeed);
    }
}
