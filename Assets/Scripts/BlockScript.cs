using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour {

    public float scalingGravity = 40f;
    

    void Start()
    {

        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / scalingGravity ;
        //GetComponent<Rigidbody2D>().gravityScale = scalingGravity;

    }

    void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
            FindObjectOfType<PlayerScript>().masScore(10);

        }

    }

    //public void invalidateBlock() { this.valido = false; }
}
