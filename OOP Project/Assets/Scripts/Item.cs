using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    protected Vector3 scale;
    public virtual Vector3 GetScaling()
    {
        scale.x = GenRandomScale();
        scale.z = GenRandomScale();
        scale.y = GenRandomScale();
        return scale;
    }
    private float GenRandomScale()
    { return Random.Range(0.5f, 2f); }

    protected void ChangeScale()
    {
        Vector3 objectScale = transform.localScale;
        scale = GetScaling();
        transform.localScale = new Vector3(objectScale.x * scale.x, objectScale.y * scale.y, objectScale.z*scale.z);
    }
}
