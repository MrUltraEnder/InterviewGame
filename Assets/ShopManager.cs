using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
   private EconomyPlayer economyPlayer;

   public int coste;
    public int sellPrice;
    public int id;
    void Start()
    {
        economyPlayer = FindObjectOfType<EconomyPlayer>();
    }

    void Update()
    {
        
    }

    public void Buy ()
    {
        if(economyPlayer.chips >= coste){
           economyPlayer.chips -= coste;
           economyPlayer.currentOutfit = id;
        }
    }

    public void Sell ()
    {
        if(id == economyPlayer.currentOutfit){
            economyPlayer.chips += sellPrice;
            economyPlayer.currentOutfit = 0;
        }
        

    }

}
