using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPun
{
    private float speed = 15.0f;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical) * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}
