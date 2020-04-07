using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 5 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            Destroy(gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
    /*private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }*/
}
