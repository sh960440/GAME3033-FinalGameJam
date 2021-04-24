using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorGenetor : MonoBehaviour
{
    [SerializeField] private GameObject[] operatorPrefabs;
    [SerializeField] private GameObject SquarePrefab;
    [SerializeField] private GameObject SqrtPrefab;
    [SerializeField] private GameObject chestPrefab;
    
    void Start()
    {
        GenerateOperators();
    }

    public void GenerateOperators()
    {
        DestroyPickups();

        for (int i = 0; i < 25; i++)
        {
            int index;

            int seed = Random.Range(0, 100);
            if (seed < 35)
                index = 0;
            else if (seed >= 35 && seed < 65)
                index = 1;
            else if (seed >= 65 && seed < 85)
                index = 2;
            else
                index = 3;

            Instantiate(operatorPrefabs[index], new Vector3(Random.Range(-24.5f, 24.5f), 0.5f, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        }

        Instantiate(SquarePrefab, new Vector3(Random.Range(-24.5f, 24.5f), 0.5f, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        Instantiate(SqrtPrefab, new Vector3(Random.Range(-24.5f, 24.5f), 0.5f, Random.Range(-24.5f, 24.5f)), Quaternion.identity, this.transform);
        Instantiate(chestPrefab, new Vector3(Random.Range(-24f, 24f), 0.05f, Random.Range(-24f, 24f)), Quaternion.identity, this.transform);
    }

    private void DestroyPickups()
    {
        OperatorBehavior[] operationObjects = FindObjectsOfType<OperatorBehavior>();
        if (operationObjects.Length > 0)
        {
            foreach (OperatorBehavior obj in operationObjects)
            {
                Destroy(obj.gameObject);
            }
        }
        

        SpecialItem[] items = FindObjectsOfType<SpecialItem>();
        if (items.Length > 0)
        {
            foreach (SpecialItem item in items)
            {
                Destroy(item.gameObject);
            }
        }
    }
}