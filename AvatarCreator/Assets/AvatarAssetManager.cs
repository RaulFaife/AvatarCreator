using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarAssetManager : MonoBehaviour
{

 

    public GameObject[] stuff;
    int pos = 0;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject[] stuff = {head1, head2, head3, head4 };
        Debug.Log("Stuff: " + stuff.Length);
    }

    
    public void onRightClick()
    {
        //Cycle
        if (pos < stuff.Length - 1)
        {
            pos++;
        }
        else
        {
            pos = 0;
        }

        //Destroy all children of the body part
        foreach (Transform child in this.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        var temp = Instantiate(stuff[pos]);
        temp.transform.parent = this.transform;
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
            pos = stuff.Length - 1;
        }

        //Destroy all children of the body part
        foreach (Transform child in this.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        var temp = Instantiate(stuff[pos]);
        temp.transform.parent = this.transform;
    }
}
