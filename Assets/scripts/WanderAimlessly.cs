using UnityEngine;
using System.Collections.Generic;

public class WanderAimlessly : MonoBehaviour
{

    [SerializeField] private float m_moveSpeed = 2;
    [SerializeField] private float m_turnSpeed = 200;

    [SerializeField] private Animator m_animator;
    [SerializeField] private Rigidbody m_rigidBody;

    private float m_currentV = 1.0f;
    private float m_currentH = 0;

    private readonly float m_interpolation = 10;

    void Awake()
    {
        if(!m_animator) { gameObject.GetComponent<Animator>(); }
        if(!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

	void FixedUpdate ()
    {

    	float h = 1.0f;
    	if (Random.value > 0.5f) {
    		h = -1.0f;
    	}

        m_currentV = Mathf.Lerp(m_currentV, m_currentV, Time.deltaTime * m_interpolation);
        m_currentH = Mathf.Lerp(m_currentH, h, Time.deltaTime * m_interpolation);

        transform.position += transform.forward * m_currentV * m_moveSpeed * Time.deltaTime;
        transform.Rotate(0, m_currentH * m_turnSpeed * Time.deltaTime, 0);

        m_animator.SetFloat("MoveSpeed", m_currentV);
    }

    
}