using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float _speed;
    private Rigidbody2D _myRigidbody;
    private Vector3 _change;
    private Animator _animator;

// #################################################################
    void Start()
    {
        _animator = GetComponent<Animator>();
        _myRigidbody = GetComponent<Rigidbody2D>();
    }

// #################################################################
// #################################################################

    void Update()
    {
        _change = Vector3.zero;
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");

        UpdateAnimationAndMove();

          
    }

// #################################################################

    void UpdateAnimationAndMove(){

        if (_change != Vector3.zero){
            MoveCharacter();
            _animator.SetFloat("moveX", _change.x);
            _animator.SetFloat("moveY", _change.y);
            _animator.SetBool("moving", true);
        }else{
            _animator.SetBool("moving",false);
        }  
    }

// #################################################################

    void MoveCharacter(){
        _myRigidbody.MovePosition(transform.position + _change * _speed * Time.deltaTime);

    }

}
