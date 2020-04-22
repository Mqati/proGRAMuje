using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UpgradeButton : MonoBehaviour
{
    // Start is called before the first frame update

    public string upgradeName;
    public double basePrice;
    private double price;
    private bool isVisible = true;
    private float power = 1.17f;
    public double ratePerClick;
    private Text text;
    private Clicker clicker;
    void Start()
    {
        price = basePrice;
        text = GetComponentInChildren<Text>();
        clicker = GameObject.Find("Clicker").GetComponent<Clicker>();
        SetName();
        if (basePrice != 10)
        {
            text.enabled = false;
            GetComponent<Image>().enabled = false;
            isVisible = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isVisible == false && clicker.GetCandy() >= basePrice)
        {
            text.enabled = true;
            GetComponent<Image>().enabled = true;
            isVisible = true;
        }
    }

    void SetName()
    {
        text.text = upgradeName + "\n(" + price + ")";
    }

    public void BuyUpgrade()
    {
        double currentCandy = clicker.GetCandy();
        if(price <= currentCandy)
        {
            clicker.SetCandyPerClick(ratePerClick);
            clicker.SetCandy(price);
            price = Math.Round(Math.Pow(basePrice, power));
            power += 0.23f;
            SetName();
        }
    }
}
