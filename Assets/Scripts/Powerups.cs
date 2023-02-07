using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    private float _speed = 3.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Triple Shot Prefab
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -4.5f)
        {
            Destroy(this.gameObject);
        }
    }
    //Triple Shot collected
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //communicate with the Player script
            //create a handle to the component I want
            //assign the handle to the component
            Player player = other.transform.GetComponent<Player>();
            if ( player != null)
            {
                player.TripleShotActive();
            }
            Destroy(this.gameObject);
        }
    }
   
}
