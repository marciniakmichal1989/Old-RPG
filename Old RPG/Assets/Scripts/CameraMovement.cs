using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform _target;
    public float _smoothing;
    public Vector2 _maxPosiotion;
    public Vector2 _minPosiotion;



    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(_target.position.x,_target.position.y,transform.position.z);

        targetPosition.x = Mathf.Clamp(_target.position.x, _minPosiotion.x,_maxPosiotion.x);
        targetPosition.y = Mathf.Clamp(_target.position.y, _minPosiotion.y,_maxPosiotion.y);

        if (transform.position != _target.position){
                transform.position = Vector3.Lerp(transform.position,targetPosition,_smoothing);
        }
    }
}
