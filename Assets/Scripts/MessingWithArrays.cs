using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ALWAYS BE SAVING
//CTRL - S
public class MessingWithArrays : MonoBehaviour
{
    [SerializeField]
    public string[] myStringArray;
    
    // Start is called before the first frame update
    void Start()
    {
        int x = 1;

        Debug.Log(myStringArray[x]);

        if (x==1)
        {
            //if true do these things
        }
        else
        {
            //if false do these things   
        }
        
        
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
