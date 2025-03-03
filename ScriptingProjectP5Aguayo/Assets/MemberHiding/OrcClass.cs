using System.Collections;
using UnityEngine;

public class Orc : Enemy3
{
    //This hides the Enemy version
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
