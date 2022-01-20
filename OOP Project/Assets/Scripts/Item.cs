using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected Vector3 scale;
    protected Vector3 Scaling(float scalefactor = 1)
    {
        scale.x = GenRandomScale()*scalefactor;
        scale.z = GenRandomScale()*scalefactor;
        scale.y = GenRandomScale()*scalefactor;
        return scale;
    }
    private float GenRandomScale()
    { return Random.Range(0.5f, 2f); }
}
