using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour 
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private Vector3 _offset;
    public Vector3 Offset{ get; set; }

    [SerializeField]
    private Quaternion _rotationOffset;
    public Quaternion RotationOffset { get; set; }

	private void Update()
	{
        transform.position = _target.position + _offset;
      //  transform.rotation = Quaternion.RotateTowards(transform.rotation, _target.transform.rotation, 2f);
	}
}
