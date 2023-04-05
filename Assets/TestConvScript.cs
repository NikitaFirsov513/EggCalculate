using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestConvScript : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    public Material mt;
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        mt.mainTextureOffset = new Vector2( 0f, -Time.time * 5 * Time.deltaTime);
        Vector3 pos = rb.position;
        rb.position += Vector3.forward * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
