using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    [SerializeField] private Ball _ball;

    private bool _isStarted;
    
    private void Update()
    {
        if (_isStarted)
            return;
        
        _ball.MoveWithPad();
        
        if (Input.GetMouseButtonDown(0))
        {
            StartBall();
        }
    }

    private void StartBall()
    {
        _isStarted = true;
        _ball.StartMove();
    }
    
    

  
}
