﻿using UnityEngine;
using System.Collections;

public class StickyObjectController : MonoBehaviour {
	

	void OnCollisionEnter2D(Collision2D collision ) {
		if(collision.gameObject.tag=="hero"){ 
			print("hit");
			this.transform.parent = collision.gameObject.transform;
			this.transform.localPosition = new Vector3(0.31f,0.41f,-1);
			collision.gameObject.SendMessage("itemCaptured", this.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D collider ) {
		if(collider.gameObject.tag=="hero"){ 
			this.collider2D.isTrigger = false;
			this.gameObject.AddComponent<Rigidbody2D>();
			//rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionZ;
			//rb.interpolation = RigidbodyInterpolation.Interpolate;
			//rb.collisionDetectionMode = CollisionDetectionMode.Discrete;
		}
	}

}

