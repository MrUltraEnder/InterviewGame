using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ClothesData", menuName = "ClothesData", order = 1)]
public class ClothesData : ScriptableObject
{
   [SerializeField] private string name;
   [SerializeField] private string description;

   [SerializeField] private Sprite ropa;

    [SerializeField]private int cost;
    [SerializeField]private int sellPrice;

    [SerializeField]private int Id;

    public string Name{ get {return name;} }
    public string Description{ get {return description;} }

    public int Cost{ get {return cost;} }

    public int SellPrice{ get {return sellPrice;} }

    public Sprite Ropa{ get {return ropa;} }

    public int id{ get {return Id;} }
}
