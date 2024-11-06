using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tryingtable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 1;
        int j = 1;
        while(i <= 5){
            while(j <= 10){
                Debug.Log(i * j);
                j ++;
            }
           // j = 1;
            i ++;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
