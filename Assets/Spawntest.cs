using UnityEngine;
using System.Collections;

public class Spawntest : MonoBehaviour
{
	[SerializeField] GameObject m_prefab;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine( SpawnCubesCoroutine());
	}

	IEnumerator SpawnCubesCoroutine()
	{
		Vector3 pos = Vector3.zero;
		while( true )
		{
			Instantiate( m_prefab, pos, Quaternion.identity );
			pos.x += 3.0f;
			if( pos.x >= 150.0f )
				pos.x -= 150.0f;
			yield return new WaitForSeconds( 1.0f );
		}
	}
}
