using UnityEngine;

public class Player : MonoBehaviour
{
    //public fields
    private float moveSpeed = 5f;
    //Property Movespeed
    public float Movespeed
    {
        get => moveSpeed; private set => moveSpeed = value;
    }
    private float jumpForce = 10f;

    private Rigidbody2D rb;

    private bool isInvulnerable=false;

    //Property Invulnerable
    public bool IsInvulnerable { get;private set; }

    public void SetMoveSpeed(float newSpeed)
    {
  
        Debug.Log($"Player's MoveSpeed = {Movespeed}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        Debug.Log($"Player Invulnerability is {IsInvulnerable}");
    }

    public void OnTriggerEnter2D(Collider2D player)
    {
        PowerUpBase item = player.GetComponent<PowerUpBase>();
        if (item != null)
        {
            item.ApplyEffect(player);
        }
       
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity=new Vector2 (moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        { 
            rb.linearVelocity=new Vector2 (rb.linearVelocity.x,jumpForce);
        }
    }
}
