using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameSettings : MonoBehaviour
{
    public Text speedText;
    public Text sizeText;

    // Start is called before the first frame update
    void Start()
    {
        sizeText.text = ScreenSettings.DropdownSizeMultiplier.ToString();
        speedText.text = ScreenSettings.speed.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
