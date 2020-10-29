using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 _cameraChange;
    public Vector3 _playerChange;
    private CameraMovement cam;
    void Start()
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
                cam._minPosiotion += _cameraChange;
                cam._maxPosiotion += _cameraChange;
                other.transform.position += _playerChange;
        }

    }
    
}
