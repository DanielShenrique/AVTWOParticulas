using System.Collections;
using UnityEngine;

public class Roll : MonoBehaviour
{
	public Rigidbody diceRigidbody;

	public float impulse = 30.0f;
	public Vector3 minTorque = new Vector3( 0.0f, 0.0f, 0.0f );
	public Vector3 maxTorque = new Vector3( 10.0f, 10.0f, 0.0f );
    public float torqueDelay = 0.5f;

    private void OnMouseDown()
	{
		diceRigidbody.AddForce( new Vector3( 0.0f, impulse, 0.0f ), ForceMode.Impulse );
        StartCoroutine(AddTorqueDelayed());
	}

    private IEnumerator AddTorqueDelayed()
    {
        yield return new WaitForSeconds(torqueDelay);

		Vector3 torque = new Vector3();
		torque.x = Random.Range( minTorque.x, maxTorque.x );
		torque.y = Random.Range( minTorque.y, maxTorque.y );
		torque.z = Random.Range( minTorque.z, maxTorque.z );

		diceRigidbody.AddTorque( torque, ForceMode.Impulse );
    }
}
