using System.Collections;
using UnityEngine;

public class SumClass
{
    //Here is a generic method. Notice the generic type 'T'. This 'T' will be replaced at runtime with an actual type. 
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
