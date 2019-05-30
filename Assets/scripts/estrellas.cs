using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class estrellas : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided" + collision.gameObject.tag);
    }
}
