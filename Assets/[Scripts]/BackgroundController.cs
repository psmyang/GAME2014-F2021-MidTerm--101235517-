//*********************************************************************************************************
// GAME2014-F2020-MidTerm-101235517.C# Unity by Mariam Ogunlesi (C) October 19th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101285729
//
// Midterm Test submission.
//
// Description: Modify the Space Shooter Demo
//
// Modified: October 20th 2021
//
//  File Name: BackgroundController.cs
//
//
// Revision History: Changed background scrolling from right to left.
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
