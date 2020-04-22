using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 position = new Vector2(0,0);
    public float posChange;
    public int lives, points;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        points = 0;
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != 3)
            position = new Vector2(transform.position.x, transform.position.y + posChange);
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -3)
            position = new Vector2(transform.position.x, transform.position.y - posChange);

        transform.position = position;
    }

    public void TakeHit()
    {
        lives--; 
    }

    public void OneUp()
    {
        if(lives < 3)
            lives++;
    }

    public void AddScore()
    {
        points += 100;
    }

}
