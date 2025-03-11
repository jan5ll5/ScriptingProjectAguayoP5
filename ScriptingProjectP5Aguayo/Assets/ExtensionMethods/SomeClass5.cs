using System.Collections;
using UnityEngine;

public class SomeClass5 : MonoBehaviour
{
    
    void Start()
    {
        //Notice how you pass no parameter into this extension method even though you had one in thr method declaration.
        //The transform object that this method is called from automatically gets passes in as the first parameter.
        transform.ResetTransformation();
    }
}
