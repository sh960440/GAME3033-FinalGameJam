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
        switch (operation)
        {
            case Operation.ADD:
                value = Random.Range(5, 20);
                break;
            case Operation.SUBTRACT:
                value = Random.Range(5, 20);
                break;
            case Operation.MULTIPLY:
                value = Random.Range(5, 10);
                break;
            case Operation.DIVIDE:
                value = Random.Range(5, 20);
                break;
        }
    }
}