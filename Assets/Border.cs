﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.name == "BulletSpawnLeft" || coll.gameObject.name == "BulletSpawnRight") {
            Destroy(coll.gameObject);
        }
		
	}
}
