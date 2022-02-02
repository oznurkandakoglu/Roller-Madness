﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
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
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        scoreManager.score ++;
        Destroy(gameObject);
    }
}
