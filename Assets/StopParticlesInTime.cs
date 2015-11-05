using UnityEngine;
using System.Collections;

public class StopParticlesInTime : MonoBehaviour
{
	[SerializeField] float m_duration = 1.0f;
	[SerializeField] ParticleSystem m_particleSystem;
	[SerializeField] Color m_newColor;

	// Use this for initialization
	void Start ()
	{
		Invoke( "DoSomething", m_duration );
	}

	void DoSomething()
	{
		m_particleSystem.startColor = m_newColor;
	}
}
