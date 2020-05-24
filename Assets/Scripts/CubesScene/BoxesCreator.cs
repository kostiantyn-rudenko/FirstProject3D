using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxesCreator : MonoBehaviour
{
    [SerializeField] GameObject _cubePrefab = null;
    Transform _anchor;
    private void Start()
    {
        _anchor = gameObject.transform;
        CreateCubes(10, 10, 10);
    }

    private void CreateCubes(int xCount, int yCount, int zCount)
    {
        for (int i = 0; i <= xCount; i++)
        {
            float xPos = _anchor.position.x + (i - xCount/2) * _cubePrefab.transform.localScale.x;
            for (int j = 0; j <= xCount; j++)
            {
                float yPos = _anchor.position.y + j * _cubePrefab.transform.localScale.y;
                for (int k = 0; k <= xCount; k++)
                {
                    float zPos = _anchor.position.z + (k - zCount/2) * _cubePrefab.transform.localScale.z;

                    GameObject.Instantiate(_cubePrefab, new Vector3(xPos, yPos, zPos), Quaternion.identity, _anchor);
                }
            }
        }
    }
}
