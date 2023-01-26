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
        //Enemy Movement
        transform.Translate(Vector3.down * _enemySpeed * Time.deltaTime); 
        
        
        //Enemy Screen Wrap
        if (transform.position.y < -5f)
        {
            float randomX = Random.Range(-8f, 8f);
            transform.position = new Vector3(randomX, 7, 0);
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
       
        //Destroy Enemy
        //damage the Player
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                player.Damage();
            }
            Destroy(this.gameObject);
        }
        
        //destroy laser
        //destroy Enemy
        if (other.tag == "laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }

    }


}
