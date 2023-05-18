using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashBalance : MonoBehaviour
{

    static public int cashAmount;
    public Text cashText;

    // Start is called before the first frame update
    void Start()
    {
        cashAmount = 1000000000;
        cashText.text = cashAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        cashText.text = cashAmount.ToString();

    }
}
