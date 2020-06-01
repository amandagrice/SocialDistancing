using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpFoodOnCollision : MonoBehaviour {

	public int goalCount = 5;
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
     		for(int i = 0; i < Animators.Length; i++) {
     			Animators[i].SetTrigger("Pickup");
     		}
            Destroy(CollidedItem);
            goalCount--;
            if (goalCount == 0) {
        		Application.LoadLevel(2);
        	}
        }
     }

}
