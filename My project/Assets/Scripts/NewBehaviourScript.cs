using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text x;
    public int c = 0;
    public GameObject obj;
    // Start is called before the first frame update
    public bool a=true;
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
    public void OnCollisionEnter()
    {
        c--;
        x.text = c.ToString();
    }
    // Update is called once per frame
}
