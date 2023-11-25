using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float SpeedY;
    public int DirectionX;
    public int DirectionY;
    public float SpeedX;
    private Rigidbody2D _compRigidbody;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>(); 
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector2(transform.position.x + SpeedX * Time.deltaTime, 0);
    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(SpeedX*DirectionX, SpeedY * DirectionY);
        
    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        if(collision.gameObject.tag == "Muro")
        {
            if (DirectionX == 1)
            {
                DirectionX = -1;
            }else if (DirectionX == -1)
            {
                DirectionX = 1;
            }
        }
        if(collision.gameObject.tag == "XD")
        {
            if (DirectionY == 1)
            {
                DirectionY = -1;
            }
            else if (DirectionY == -1)
            {
                DirectionY = 1;
            }
        }
    }

}
