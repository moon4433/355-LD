﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace White
{
    public class KillBall : MonoBehaviour
    {
        public float killPlane;
        public GameObject ball;
        public static bool ballIsDead = false;
        
        void Update()
        {
            if (ball.transform.position.z < killPlane)
            {
                ballIsDead = true;
                Destroy(ball);
            }
        }
    }
}