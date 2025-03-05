using System.Collections;
using UnityEngine;

public class Apple3 : Fruit
{
   public Apple3()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods are overrides and therefore can override any virtual methods in the parent class.
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello2()
    {
        base.SayHello2();
        Debug.Log("Hello, I am an apple.");
    }
    
}
