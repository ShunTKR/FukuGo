using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RoadCreator : MonoBehaviour
{
    [SerializeField] private Transform _road;
    [SerializeField] private int _count;
    [SerializeField] private Vector3 _delta;

    private void Awake()
    {
        var pos = Vector3.zero;

        for (int i = 0; i < _count; i++)
        {
            Instantiate(_road, pos, Quaternion.identity, transform);
            pos += _delta;
        }
    }
}
