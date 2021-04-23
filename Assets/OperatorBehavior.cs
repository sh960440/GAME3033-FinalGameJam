using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Operation
{
    ADD,
    SUBTRACT,
    MULTIPLY,
    DIVIDE
}
public class OperatorBehavior : MonoBehaviour
{
    public Operation operation;
    public int value = 1;

    void Start()
    {
        
    }
}