using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    // Start is called before the first frame update
    private bool isColided = false;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(!isColided)
        {
            print(collision.gameObject.name);
            GetComponent<MeshRenderer>().material.color = Color.red;
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            scoreManager.score--;
            isColided = true;
        }
        
    }
    /*private void OnCollisionStay(Collision collision)
    {
        print(collision.gameObject.name);
    }*/
   /* private void OnCollisionExit(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        
    }*/
}
