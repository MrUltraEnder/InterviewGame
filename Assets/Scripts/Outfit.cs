using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Outfit : MonoBehaviour
{
    [SerializeField] ClothesData clothesData;


    public void ShowOutfit()
    {
        TextMeshProUGUI name = GameObject.Find("NameRopa").GetComponent<TextMeshProUGUI>();
        name.text = clothesData.Name;
        TextMeshProUGUI description = GameObject.Find("Description").GetComponent<TextMeshProUGUI>();
        description.text = clothesData.Description;
        TextMeshProUGUI cost = GameObject.Find("Cost").GetComponent<TextMeshProUGUI>();
        cost.text = clothesData.Cost.ToString();
        TextMeshProUGUI sellPrice = GameObject.Find("sellPrice").GetComponent<TextMeshProUGUI>();
        sellPrice.text = clothesData.SellPrice.ToString();
    }
}
