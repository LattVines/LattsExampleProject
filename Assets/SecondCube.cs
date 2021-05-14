using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondCube : MonoBehaviour
{

    public Text health_label;//SET IN EDITOR


    public void Damage(int amount)
    {
        print("this object took damage: " + this.name + " damage: " + amount);
    }

}
