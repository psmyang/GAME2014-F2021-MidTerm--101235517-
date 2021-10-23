//*********************************************************************************************************
// GAME2014-F2021-MidTerm-101285729.C# Unity by Mingkun Yang (C) October 19th 2021 All Rights Reserved.
//
// Name: Mingkun Yang 
//
// StudentID: 101235517
//
// Midterm Test submission.
//
// Description: Modify the Space Shooter Demo
//
// Modified: October 20th 2021
//
// File Name: EnemyController.cs
//
//
// Revision History: Changed enemy movement to up and down and set up boundary.
//
//******************************************************************************************************


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
