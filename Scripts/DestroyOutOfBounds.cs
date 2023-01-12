using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public PlayerController Player;
    private float topBound = 40;
    private float rightBound = -25;
    private float lowerBound = -10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < rightBound || transform.position.z < lowerBound)
        {
           Destroy(gameObject);
            LiveCounterFunc();
        } else if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            LiveCounterFunc();
        }
    }

    private void LiveCounterFunc()
    {
        if (Player.liveCounter > 1)
        {
            Player.liveCounter--;
            Debug.Log("Live: " + Player.liveCounter);
        }
        else
        {
            Debug.Log("Game Over!! You are died :/");
        }
    }
}
