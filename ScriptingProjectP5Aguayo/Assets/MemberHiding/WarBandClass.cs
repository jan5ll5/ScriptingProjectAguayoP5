using System.Collections;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy3();
        Humanoid orc = new Orc();

        //Notice how each Humanoid variable contains a reference to a different class in the inheritance hierarchy, yet each of them calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
