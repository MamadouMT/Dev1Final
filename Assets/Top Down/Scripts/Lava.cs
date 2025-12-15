// using UnityEngine;
//
// public class Lava : MonoBehaviour
// {
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         
//                   transform.position+=new Vector3(0,1.2f,0)*Time.deltaTime;
//                
//     }
// }

using UnityEngine;

public class Lava : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerMovement player;
    
    
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
