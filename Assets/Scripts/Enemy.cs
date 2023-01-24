using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _enemySpeed = 4f;
    
    void Start()
    {
        transform.position = new Vector3(0, 8f, 0);
    }

    
    void Update()
    {
        //move down at 4 meters per second
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime); 
        
        //if at bottom of screen
        //respawn at top of screen with a new random x position
        if (transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if other is Player
        //Destroy Us
        //damage the Player

        //if other is laser
        //destroy laser
        //destroy us
    }


}
