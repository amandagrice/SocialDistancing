using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSick : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Zombie")) {
			Application.LoadLevel(3);
		}
    }

}
