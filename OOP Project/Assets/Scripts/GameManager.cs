using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public static string itemType { get; private set;} // encapsulation example – itemtype can be set in this class, but can only be get in other classes.
   // Start is called before the first frame update
    void Awake()
    {
        // if (Instance != null)
        // { 
	    //     Destroy(gameObject);
        //     return;
	    // }
        itemType = "Cube"; // default item
        // Instance = this;
        DontDestroyOnLoad(gameObject); // don't destroy when scene changes
    }

    public void SelectCube() 
    {
        Debug.Log("Cube currently selected");
        itemType = "Cube";
    }

    public void SelectBall() 
    { 
        Debug.Log("Ball currently selected");
	    itemType = "Ball";
    }
}
