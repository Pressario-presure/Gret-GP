
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;
    [SerializeField] private Transform _target;
    [SerializeField, Range(0, 1)] private float _smoothing;
    // Update is called once per frame
    void FixedUpdate()
    {  
        if (_target != null)
        {
            Vector3 nextPosition = Vector3.Lerp(transform.position, _target.position, _smoothing);
            nextPosition.z = transform.position.z;
            transform.position = nextPosition;
        }
        Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed * Time.deltaTime);
    }
}