using UnityEngine;

public class lava_script : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerScript player;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <60 && player.Score>=1)
        {
            transform.position+=new Vector3(0,1.2f,0)*Time.deltaTime;
        }
    }
}
