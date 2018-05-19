using System.Collections;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{

    public Click click;

    public UnityEngine.UI.Text itemInfo;

    public float cost;

    public int count = 0;

    public int clickPower;

    public string itemName;

    private float basecost;

    private void Start(){

        basecost = cost;


    }

    void Update(){

        itemInfo.text = itemName + "\nCusto: " + cost + "\nPoder: " +"+"+ clickPower;


    }

    public void PurchaseUpgrade(){

        if (click.coin >= cost){


            click.coin = click.coin - cost;

            count += 1;

            click.coinperclick += clickPower;

            cost =Mathf.Round(basecost * Mathf.Pow(1.15f, count));

        }

    }


}
