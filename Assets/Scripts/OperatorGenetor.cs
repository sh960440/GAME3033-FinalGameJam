using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorGenetor : MonoBehaviour
{
    [SerializeField] private GameObject[] operatorPrefabs;
    [SerializeField] private GameObject SquarePrefab;
    [SerializeField] private GameObject SqrtPrefab;
    
    void Start()
    {
        GenerateOperators();
    }

    public void GenerateOperators()
    {
        DestroyPickups();

        for (int j = 0; j < 25; j++)
        {
            int index;

            int seed = Random.Range(0, 100);
            if (seed < 35)
                index = 0;
            else if (seed >= 35 && seed < 65)
                index = 1;
            else if (seed >= 65 && seed < 90)
                index = 2;
            else
                index = 3;

            Instantiate(operatorPrefabs[index], new Vector3(Random.Range(-24.5f, 24.5f), 1, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        }

        Instantiate(SquarePrefab, new Vector3(Random.Range(-24.5f, 24.5f), 1, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        Instantiate(SqrtPrefab, new Vector3(Random.Range(-24.5f, 24.5f), 1, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
    }

    private void DestroyPickups()
    {
        OperatorBehavior[] operationObjects = FindObjectsOfType<OperatorBehavior>();
        foreach (OperatorBehavior obj in operationObjects)
        {
            Destroy(obj.gameObject);
        }
    }
}
