using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EconomyPlayer : MonoBehaviour
{
    public int chips;

    private TextMeshProUGUI chipsText;
    void Start()
    {
        chipsText = GameObject.Find("ChipsText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        chipsText.text = chips.ToString();
    }
}
