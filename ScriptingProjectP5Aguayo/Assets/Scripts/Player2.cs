using System.Collections;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Static variables are shared across all instances of a class
    public static int player2Count = 0;

    void Start()
    {
        //Increment the static variable to know how many objects of this class have been created
        player2Count++;
    }

   
}
