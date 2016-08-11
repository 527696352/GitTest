using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
        transform.Rotate(new Vector3(0, 1, 0));
	}
}
