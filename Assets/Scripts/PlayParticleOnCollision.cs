using UnityEngine;

public class PlayParticleOnCollision : MonoBehaviour
{
	public ParticleSystem[] particles;

	private void OnCollisionEnter( Collision collision )
	{
		foreach( var particle in particles )
		{
			particle.Play();
		}
	}
}
