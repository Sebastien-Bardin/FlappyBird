using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameManager game_manager;
    //velocity of the bird
    public float velocity = 1;

    //Bird rigid body
    private Rigidbody2D Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            //Jump
            Rigidbody2D.velocity = Vector2.up * velocity;
        }

        else if(Input.GetKeyDown(KeyCode.Space)){
            //Jump
            Rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {//calling the method to stop the game when we collide 
        game_manager.GameOver();
    }
}
