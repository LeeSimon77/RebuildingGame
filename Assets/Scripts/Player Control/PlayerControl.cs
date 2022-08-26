using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizMultiplier = Input.GetAxis("Horizontal");
        float vertMultiplier = Input.GetAxis("Vertical");

        body.velocity = new Vector3(horizMultiplier * 10f, 0, vertMultiplier * 10f);
    }
}
