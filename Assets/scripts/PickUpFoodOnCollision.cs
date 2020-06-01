using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpFoodOnCollision : MonoBehaviour {

    private Animator[] Animators;
	public static GameObject CollidedItem;

	private void Start() {
        Animators = FindObjectsOfType<Animator>();
    }

	void OnTriggerEnter(Collider other) {
		CollidedItem = other.gameObject;
    }

     void OnTriggerExit() {
     	CollidedItem = null;
     }

     void Update() {
     	if (Input.GetKeyDown(KeyCode.E) && CollidedItem && CollidedItem.CompareTag("Food")) {
     		Animators[0].SetTrigger("Pickup");
            Destroy(CollidedItem);
        }
     }

}
