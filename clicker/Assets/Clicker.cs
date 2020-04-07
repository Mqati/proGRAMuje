﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    private double candy = 0;
    private Text CandyCounterText;
    private double candyPerClick = 1;
    // Start is called before the first frame update
    void Start()
    {
        CandyCounterText = GameObject.Find("CandyCounterText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CandyCounterText.text = "Candy collected: " + candy;
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
}
