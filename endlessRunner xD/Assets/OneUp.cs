using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneUp : MonoBehaviour
{
    private Player player;
    public Sprite shell;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x - player.transform.position.x < 10)
            gameObject.GetComponent<SpriteRenderer>().sprite = shell;
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.OneUp();
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
