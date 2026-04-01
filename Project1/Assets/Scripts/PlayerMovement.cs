using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(3, -2);
        //Invoke(nameof(AcceptDefeat), 5);

        rb = GetComponent<Rigidbody2D>();
    }
    
    void AcceptDefeat()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xAxis * 5f, yAxis * 5f);
    }
}
