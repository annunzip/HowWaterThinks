using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBounce : MonoBehaviour {

    Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        // Increase max angular velocity or we won't see much spin.
        _rb.maxAngularVelocity = 1000;

        StartCoroutine(ChangeRotation());
    }

    private IEnumerator ChangeRotation()
    {
        while (true)
        {
            _rb.AddTorque(new Vector3(10 * UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f), UnityEngine.Random.Range(0, 1f)), ForceMode.Impulse);
            yield return new WaitForSeconds(1);
        }
    }
}
