using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Player : MonoBehaviour
{
  public float Speed = 3.0f;
  public float HorizontalAxis;
  public float VerticalAxis;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HorizontalAxis = Input.GetAxis("Horizontal");
        VerticalAxis = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * HorizontalAxis * Speed);
        transform.Translate(Vector3.forward * Time.deltaTime * VerticalAxis * Speed);
    }
}
