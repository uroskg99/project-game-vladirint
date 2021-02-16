using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform castPoint;
    public LayerMask whatIsWall;

    private Rigidbody2D rb;
    public float moveSpeed;

    private Vector2 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.right;
    }

    private void Update()
    {
        ChangeDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void ChangeDirection()
    {
        //puca linecast
        RaycastHit2D hit = Physics2D.Raycast(castPoint.position, direction, 0.1f);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Wall"))
            {
                //direction = Vector2.down;
                //rendom direction
            }
        }
        

    }

    private void Move()
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
    }

}
