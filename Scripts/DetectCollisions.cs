using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //public PlayerController Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name != "Player") {
            if(gameObject.name == "Pizza(Clone)") { 
                Destroy(gameObject);
                //Player.score += 1;
                //Debug.Log("Score: " + Player.score);
            }
        }
    }
}
