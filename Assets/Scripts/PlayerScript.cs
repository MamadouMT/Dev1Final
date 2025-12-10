using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them

    //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public Rigidbody2D RB;

    //TextMeshPro is a component that draws text on the screen.
    //We use this one to show our score.
    public TextMeshPro ScoreText;

    //This will control how fast the player moves
    public float Speed = 5;

    //This is how many points we currently have
    public int Score = 0;
//spirte renderer b/c HP is one
    public SpriteRenderer HP;
    //Start automatically gets triggered once when the objects turns on/the game starts
    public float CurrentHealth = 6;

    public float damage = 1;

    void Start()
    {
        //During setup we call UpdateScore to make sure our score text looks correct
        UpdateScore();
    }

    //Update is a lot like Start, but it automatically gets triggered once per frame
    //Most of an object's code will be called from Update--it controls things that happen in real time
    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0, 0);

        //Then we use if statement to figure out what that variable should look like

        //If I hold the right arrow key, the player should move right. . .
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }

        //If I hold the left arrow, the player should move left. . .
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }

        //If I hold the up arrow, the player should move up. . .
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }

        //If I hold the down arrow, the player should move down. . .
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }

        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;

        if (transform.position.x > 8)
        {
            Vector3 pos = transform.position;


            pos.x = -8;
            //transform.position.x <-8
        }
    }

 

    //This function updates the game's score text to show how many points you have
    //Even if your 'score' variable goes up, if you don't update the text the player doesn't know
    public void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }

    public void DamnageHP()
    {
        if (CurrentHealth > 0)
        {
            CurrentHealth = CurrentHealth - damage;
        }
        HP.transform.localScale = new Vector3(CurrentHealth, HP.transform.localScale.y, HP.transform.localScale.z);
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

//If this function is called, the player character dies. The game goes to a 'Game Over' screen.
    public void Die()
    
    {
        SceneManager.LoadScene("Game Over");
    }
}
