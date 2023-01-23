    using System;
using System.Collections;
using System.Collections.Generic;
    using Unity.VisualScripting;
    using UnityEngine;
    using Random = UnityEngine.Random;

    public class powerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
      
            col.gameObject.GetComponent<Rigidbody2D>().gravityScale = Random.Range(10,-10);
            Bola.velocidad = 100;
        

        
        //Desactivo el objeto
        gameObject.SetActive(false);
        
        //Destruyo el objeto
        //Destroy(col.gameObject);
    }
}