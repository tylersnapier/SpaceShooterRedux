using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private float _laserSpeed = 8.0f;
   

    
    void Update()
    {
        //Laser Movement
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);

      
        if (transform.position.y > 8f)
        {
            Destroy(this.gameObject);
        }
    }
}
