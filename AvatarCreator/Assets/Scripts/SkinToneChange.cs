using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinToneChange : MonoBehaviour
{
    public Material[] skinTones;
    int pos = 0;

    public void onRightClick()
    {
        //Cycle
        if (pos < skinTones.Length - 1)
        {
            pos++;
        }
        else
        {
            pos = 0;
        }

        
        foreach (Transform child in this.transform)
        {
            child.GetComponent<Renderer>().material = skinTones[pos];
        }

        
    }

    public void onLeftClick()
    {
        //Cycle
        if (0 < pos)
        {
            pos--;
        }
        else
        {
            pos = skinTones.Length - 1;
        }

        foreach (Transform child in this.transform)
        {
            child.GetComponent<Renderer>().material = skinTones[pos];
        }

    }
}
