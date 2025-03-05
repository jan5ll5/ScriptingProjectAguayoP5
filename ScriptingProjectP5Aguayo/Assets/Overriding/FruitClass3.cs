using System.Collections;
using UnityEngine;

public class FruitClass3 : MonoBehaviour
{
    
    public FruitClass3()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    //These methods arre virtual and thus can be overriden in child classes

    public virtual void Chop4()
    {
        base.Chop4();
        Debug.Log("The fruit has been chopped");
    }

    public virtual void SayHello2()
    {
        base.SayHello2();
        Debug.Log("Hello, I am an fruit.");
    }
   
}
