using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D body;

    bool leftMouseButton;
    bool rightMouseButton;
    [SerializeField]private float offsetX = 1.0f;

    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        leftMouseButton = Input.GetButtonDown("Fire1");
        rightMouseButton = Input.GetButtonDown("Fire2");
        if (leftMouseButton == true)
        {
            body.transform.Translate(Displace(-offsetX));
        }

        if (rightMouseButton == true)
        {
            body.transform.Translate(Displace(offsetX));
        }



    }

    Vector2 Displace(float valueToDisplace)
    {
        Vector2 displacement = new Vector2(valueToDisplace, 0);
        return displacement;
    }
}
