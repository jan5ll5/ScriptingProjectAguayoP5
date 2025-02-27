using System.Collections;
using UnityEngine;

public class SumOtherClass : MonoBehaviour
{

    void Start()
    {
        SumClass myClass = new SumClass();

        //In order to use this method you must tell the method what type to replace 'T' with.
        myClass.GenericMethod<int>(5);
    }

}
