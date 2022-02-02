using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform target;
    void Start()
    {
        target = GameObject.FindWithTag("Player").GetComponent<Transform>();
     
    }
    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
    }
}
