using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Item
{
    // Start is called before the first frame update
    void Awake()
    {
        Vector3 objectScale = transform.localScale;
        scale = Scaling();
        transform.localScale = new Vector3(objectScale.x * scale.x, objectScale.y * scale.y, objectScale.z*scale.z);
    }
}
