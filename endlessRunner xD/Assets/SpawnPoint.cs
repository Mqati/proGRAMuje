﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPoint : MonoBehaviour
{
    public GameObject ghost;
    //private int[,] points = { { 0, 3 }, {0, -3}, {-3, 3 }};
    //private int posY = 0;
    
    void Start()
    {
        //InvokeRepeating("GenerateGhosts", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
            //int rand = Random.Range(0, 2);
            //posY = posY == rand ? (rand + 1 % 3) : rand;
            //Instantiate(ghost, (new Vector2(transform.position.x, points[posY,0])), Quaternion.identity);
            //Instantiate(ghost, (new Vector2(transform.position.x, points[posY, 1])), Quaternion.identity);
            Instantiate(ghost, transform.position, Quaternion.identity);
    }


}
