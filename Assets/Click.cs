using System.Collections;

using UnityEngine;

public class Click : MonoBehaviour{

    public UnityEngine.UI.Text BitCoin;

    public UnityEngine.UI.Text cpc;

    public float coin = 0.00f;

    public int coinperclick = 1;

    private void Update()
    {

        BitCoin.text = "Coin: " + coin;

        cpc.text = "CPC: " + coinperclick;


    }

    public void Clicked()
    {

        coin += coinperclick;

    }

}
