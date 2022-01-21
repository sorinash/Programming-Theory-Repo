using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer_Camera : MonoBehaviour
{
  public GameObject player;
  public Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
          player = GameObject.Find("Player");
          playerPosition = new Vector3(player.transform.position.x, 27, player.transform.position.z);
          transform.position = playerPosition;
    }

    // Update is called once per frame
    void Update()
    {
      playerPosition = new Vector3(player.transform.position.x, 27, player.transform.position.z);
      transform.position = playerPosition;
    }
}
