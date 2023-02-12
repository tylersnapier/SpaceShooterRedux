using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    private float _speed = 3.0f;
   
    [SerializeField] //0 = Triple Shot 1 = Speed 2 = Shields
    private int _powerupID;
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
                switch(_powerupID)
                {
                    case 0:
                        player.TripleShotActive();
                        break;
                    case 1:
                        player.SpeedBoostActive();
                        break;
                    case 2:
                        Debug.Log("Collected Shields");
                        break;
                    default:
                        Debug.Log("Default Value");
                        break;

                  

                }
            }
            Destroy(this.gameObject);
        }
    }
   
}
