using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AndroidJavaClass javaClass = new AndroidJavaClass("com.example.mylibrary.MyJavaClass");
        int result = javaClass.CallStatic<int>("add", 5, 3);
        Debug.Log("Result: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
