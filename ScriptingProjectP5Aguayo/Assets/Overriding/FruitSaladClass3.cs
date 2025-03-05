using System.Collections;
using UnityEngine;

public class FruitSaladClass3 : MonoBehaviour
{
    
   void Start()
    {
        Apple3 myApple = new Apple3();

        //Notice that the Apple version of the methods override the fruit versions. Also notice that since the Apple versions call the Fruit version with the "base" keyword, both are called.
        myApple.SayHello2();
        myApple.Chop4();

        //Overriding is also useful in a polymorphic situation. Since the methods of the Fruit class are "virtual" and the methods of the Apple class are "override", when we upcast an Apple into a Fruit, the Apple version of the Methods are used.
        Fruit3 myFruit = new Apple3();
        myFruit.SayHello2();
        myFruit.Chop4();
   }
    
}
