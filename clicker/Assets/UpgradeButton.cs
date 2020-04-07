using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    // Start is called before the first frame update

    public string upgradeName;
    public double price;
    public double ratePerClick;
    private Text text;
    private Clicker clicker;
    void Start()
    {
        text = GetComponentInChildren<Text>();
        clicker = GameObject.Find("Clicker").GetComponent<Clicker>();
        SetName();
    }

    // Update is called once per frame
    void Update()
    {
        
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
            price *= 2;
            SetName();
        }
    }
}
