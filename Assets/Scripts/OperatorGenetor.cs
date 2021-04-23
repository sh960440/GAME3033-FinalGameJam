using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorGenetor : MonoBehaviour
{
    [SerializeField] private GameObject[] operatorPrefabs;
    [SerializeField] private GameObject SquarePrefab;
    [SerializeField] private GameObject SqrtPrefab;
    [SerializeField] private float[] yPositions;
    
    // Start is called before the first frame update
    void Start()
    {
        GenerateOperator();
    }

    public void GenerateOperator()
    {
        int size = operatorPrefabs.Length;

        for (int i = 0; i < yPositions.Length; i++)
        {
            for (int j = 0; j <= 25; j++)
            {
                int index = Random.Range(0, size);
                Instantiate(operatorPrefabs[index], new Vector3(Random.Range(-24.5f, 24.5f), yPositions[i], Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
            }

            Instantiate(SquarePrefab, new Vector3(Random.Range(-24.5f, 24.5f), yPositions[i], Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
            Instantiate(SqrtPrefab, new Vector3(Random.Range(-24.5f, 24.5f), yPositions[i], Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        }
    }
}
