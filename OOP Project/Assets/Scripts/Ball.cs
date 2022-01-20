using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Item
{
    void Awake()
    {
        Vector3 objectScale = transform.localScale;
        scale = Scaling(1.5f);
        transform.localScale = new Vector3(objectScale.x * scale.x, objectScale.y * scale.y, objectScale.z*scale.z);
    }
}
