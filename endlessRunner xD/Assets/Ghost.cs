using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    // Update is called once per frame
    private Player player;

    private void Start()
    {
        player = GameObject.Find("player").GetComponent<Player>();
    }
    void Update()
    {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            player.TakeHit();
        }
    }

    
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
