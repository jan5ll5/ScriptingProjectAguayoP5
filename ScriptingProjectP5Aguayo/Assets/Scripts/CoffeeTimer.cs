using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 75.0f;
    float coldLimtTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest ()
    {
        // If the coffee's temperature is greater that the hottest drinking temperature...
        if(coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimtTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is justt right.");
        }
    }
}
