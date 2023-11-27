using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text x;
    public int c;
    public GameObject obj;
    // Start is called before the first frame update
    public bool a;
    public void Active()
    {
        
        if (a==true)
        {
            obj.SetActive(false);
            a = false;
        }
        else
        {
            obj.SetActive(true);
            a = true;
        }
    }
    // Update is called once per frame
}
