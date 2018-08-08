using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownControl : MonoBehaviour
{
    public GameObject options;
    // Use this for initialization
    void Start ()
    {
        List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();



        for (int i = 0; i < 10; ++i)
        {
            options.Add(new Dropdown.OptionData(i.ToString()));
        }

    }
	
}
