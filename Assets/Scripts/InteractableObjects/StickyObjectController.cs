﻿using UnityEngine;
using System.Collections;

public class StickyObjectController : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collision ) {
		if(collision.gameObject.tag=="hero"){ 
			this.transform.parent = collision.gameObject.transform;
			collision.gameObject.SendMessage("itemCaptured", this.gameObject);
			this.itemGrabbed();
		}
	}

	public virtual void itemGrabbed() {
	}

	void OnTriggerExit2D(Collider2D collider ) {
		if(collider.gameObject.tag=="hero"){ 
			this.collider2D.isTrigger = false;
			this.gameObject.AddComponent<Rigidbody2D>();
			this.itemDropped();
		}
	}

	public virtual void itemDropped() {
	}

}

