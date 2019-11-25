using System.Collections;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour

{
    public Transform target;
    public float smoothing = 5.0f;
    // Start is called before the first frame updat

    // Update is called once per frame
    void FixedUpdate()
    {
    
      Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing * 0.001f));   
    }

}
