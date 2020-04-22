using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Clicker : MonoBehaviour
{
    private double candy = 0;
    private Text CandyCounterText;
    private double candyPerClick = 1;
    private double candyPerTick = 0;
    // Start is called before the first frame update
    void Start()
    {
        CandyCounterText = GameObject.Find("CandyCounterText").GetComponent<Text>();
        InvokeRepeating("PassiveCandy", 0, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        CandyCounterText.text = "Candy collected: " + String.Format("{0:0.#}",candy);
    }

    public void AddCandy()
    {
        candy += candyPerClick; 
    }

    public double GetCandy()
    {
        return candy;
    }

    public void SetCandyPerClick(double addToCandyPerClick)
    {
        candyPerClick += addToCandyPerClick;
    }

    public void SetCandy(double price)
    {
        candy -= price;
    }

    private void PassiveCandy()
    {
        candy += candyPerTick;
    }

    public void SetCandyPerTick(double addToCandyPerTick)
    {
        candyPerTick += addToCandyPerTick;
    }
}
