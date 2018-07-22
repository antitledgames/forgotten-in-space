using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour {

    public float sPower_sus = 25, sPower_dreapta = 25, sPower_jos = 25, sPower_stanga = 25;
    public int[,] s = new int[5,3];
    private void Start()
    {
        for (int i=1;i<=4;i++)
        {
            s[i,1] = 25;
            s[i,2] = 1;
        }
    }
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W) && s[1,1]!=100)
        {
            s[1,1] ++;
            if (s[1,2] == 1)
                s[1,2]++;
            s[s[1,2],1]--;
            s[1,2]++;
            if (s[1,2] == 5)
                s[1,2] = 1;
        }
       else if (Input.GetKeyDown(KeyCode.D) && s[2, 1] != 100)
        {
            s[2, 1]++;
            if (s[2, 2] == 1)
                s[2, 2]++;
            s[s[2, 2], 1]--;
            s[2, 2]++;
            if (s[2, 2] == 5)
                s[2, 2] = 1;
        }
        else if (Input.GetKeyDown(KeyCode.S) && s[3, 1] != 100)
        {
            s[3, 1]++;
            if (s[3, 2] == 1)
                s[3, 2]++;
            s[s[3, 2], 1]--;
            s[3, 2]++;
            if (s[3, 2] == 5)
                s[3, 2] = 1;
        }
        else if (Input.GetKeyDown(KeyCode.A) && s[4, 1] != 100)
        {
            s[4, 1]++;
            if (s[4, 2] == 1)
                s[4, 2]++;
            s[s[4, 2], 1]--;
            s[4, 2]++;
            if (s[4, 2] == 5)
                s[4, 2] = 1;
        }
        
    }
}
