﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1);
    }
}
