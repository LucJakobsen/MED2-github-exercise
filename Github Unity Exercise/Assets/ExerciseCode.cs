using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExerciseCode : MonoBehaviour
{
    int myVariable = 10;

    private void Start() {
        Debug.Log("value before calling function: " + myVariable);
     
        PassByReference (ref myVariable);
        Debug.Log("value after calling function: " + myVariable);
    }

    public void PassByValue(int var)
    {
        var = var + 10;
        Debug.Log("Value inside function: " + var);
    }

    public void PassByReference(ref int var)
    {
        var = var + 20;
        Debug.Log("Value inside function: " + var);
    }

    public void HelloWorld() {
        Debog.Log("Hello!")
    }
 }