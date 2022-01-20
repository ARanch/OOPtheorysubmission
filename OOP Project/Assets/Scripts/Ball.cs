using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Item // example of inheritance
{
    void Awake()
    {
        ChangeScale(); // example of abstraction
    }
    public override Vector3 GetScaling() // example of polymorhism
    {
        return base.GetScaling() * 3f; 
    }
}
