using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownActions : MonoBehaviour
{
    public Dropdown Timer;
    public void setTimer()
    {
        for (int x=0; x < Timer.options.Count; x++)
        {
            if (Timer.value == x)
            {
                string selected = Timer.options[x].text;
                Settings.GameTime = uint.Parse(selected.Substring(0, selected.Length - 1));
                break;
            }

        }

    }
}
