using UnityEngine;
using System.Collections;

public class DestroyInTime : MonoBehaviour
{
	[SerializeField] float m_duration = 1.0f;

	// Use this for initialization
	void Start ()
	{
		Invoke( "DestroyMe", m_duration );
	}

	void DestroyMe()
	{
		Destroy( gameObject );
	}
}
