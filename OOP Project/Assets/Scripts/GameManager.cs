using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static string itemType = "Cube";
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        { 
	        Destroy(gameObject);
            return;
	    }

        Instance = this;
        DontDestroyOnLoad(gameObject); // don't destroy when scene changes
    }

    public void SelectCube() 
    {
        itemType = "Cube";
        Debug.Log("Cube currently selected");
    }

    public void SelectBall() 
    { 
	    itemType = "Ball";
        Debug.Log("Ball currently selected");
    }
}
