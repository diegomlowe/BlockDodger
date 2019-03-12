using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float speed = 15f;
    public float mapWidth = 5f;
    public float dirx;
    private int  score = 0;

    private Rigidbody2D rb;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*
        //float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        float x = Input.acceleration.x * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);*/

        dirx = Input.acceleration.x * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -mapWidth, mapWidth), transform.position.y);



    }

     void FixedUpdate()
    {

        rb.velocity = new Vector2(dirx, 0f);

    }

    void OnCollisionEnter2D()
    {
        if (this.score <= 0) { FindObjectOfType<GameManagerScript>().EndGame(); }
        else { FindObjectOfType<GameManagerScript>().gotHit(); }

        
    }

    public void masScore(int s) { this.score += s; }

    public void menosScore(int s) { this.score -= s; }

    public int getScore() { return this.score; }
    
}
