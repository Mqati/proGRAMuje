using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGate : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GameObject.Find("player").GetComponent<Player>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.AddScore();
            Destroy(gameObject);

        }
    }

}
