using System;
using UnityEngine;

public class Door : MonoBehaviour
{public PlayerScript player;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(player.Score>=1)
        {
            Destroy(gameObject);
            
        }
    }
}
