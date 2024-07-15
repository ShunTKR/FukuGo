using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DG.Tweening;

public class CameraMover : MonoBehaviour
{
    [SerializeField] private Transform[] _targets;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _duration;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOPath(
            path: _targets.Select(x => x.position + _offset).ToArray(),
            duration: _duration,
            pathType: PathType.Linear
        ).SetEase(Ease.Linear).SetLookAt(0.001f, Vector3.forward);
    }

}
