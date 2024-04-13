using UnityEngine;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb;
    Animator anim;
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal"), rb.velocity.y);
        if (Input.GetAxis("Horizontal") == 0)
        {
            anim.SetInteger("Anim", 0);
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            anim.SetInteger("Anim", 1);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }
    void Jump()
    {
        anim.SetInteger("Anim", 2);
        rb.AddForce(transform.up * 8/3, ForceMode2D.Impulse);
    }
}
