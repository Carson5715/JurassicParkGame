using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_EggCounter : MonoBehaviour
{
public Text EggText;

    // Start is called before the first frame update
    void Start()
    {
        EggText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //Set the current number of coins to display
            if(EggText.text != SC_2DCoin.totalEggs.ToString())
        {
            EggText.text = SC_2DCoin.totalEggs.ToString();
        }
    }
}