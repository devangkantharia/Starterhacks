﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandlerLeft : MonoBehaviour {

    // Use this for initialization
    public Rigidbody grenade;

	public void CreateGrenade()
    {
        Instantiate(grenade, new Vector3(0.1F, 1, 0), Quaternion.identity);
    }
}
