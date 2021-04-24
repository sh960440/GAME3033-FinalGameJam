using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum Operation
{
    ADD,
    SUBTRACT,
    MULTIPLY,
    DIVIDE
}
public class OperatorBehavior : MonoBehaviour
{
    public TMP_Text numberText;
    public Operation operation;
    public int value = 1;

    void Start()
    {
        switch (operation)
        {
            case Operation.ADD:
                value = Random.Range(3, 20);
                break;
            case Operation.SUBTRACT:
                value = Random.Range(3, 20);
                break;
            case Operation.MULTIPLY:
                value = Random.Range(2, 11);
                break;
            case Operation.DIVIDE:
                value = Random.Range(2, 11);
                break;
        }

        numberText.text = value.ToString();
    }
}