using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnPoint : MonoBehaviour
{
    public GameObject ghost;
    public GameObject pointGate;
    private int[,] points = { { 0, 3, -3 }, {-3, 0, 3}, {-3, 3, 0 }};

    private int posY = 0;
    
    void Start()
    {
        InvokeRepeating("GenerateGhosts", 0, 1);
    }

    void GenerateGhosts()
    {
            int rand = Random.Range(0, 2);
            posY = posY == rand ? ((rand + 1) % 3) : rand;
            Instantiate(ghost, (new Vector2(transform.position.x, points[posY,0])), Quaternion.identity);
            Instantiate(ghost, (new Vector2(transform.position.x, points[posY, 1])), Quaternion.identity);
            Instantiate(pointGate, (new Vector2(transform.position.x, points[posY, 2])), Quaternion.identity);
            //Instantiate(ghost, transform.position, Quaternion.identity);
    }


}
