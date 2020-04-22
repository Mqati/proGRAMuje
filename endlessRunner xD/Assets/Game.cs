using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    private Player player;
    private Text scoreText;
    private Text livesText;

    void Start()
    {
        player = GameObject.Find("player").GetComponent<Player>();
        scoreText = GameObject.Find("scoreText").GetComponent<Text>();
        livesText = GameObject.Find("livesText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.lives <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        scoreText.text = "Score: " + player.points;
        livesText.text = "Lives: " + player.lives; 
        
    }
}
