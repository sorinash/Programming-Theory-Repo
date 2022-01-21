using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Controller : Enemy
{
    // Start is called before the first frame update
    public virtual void Start()
    {
      player = GameObject.Find("Player");
      m_RotateSpeed = 40.0f;
      m_AggroDistance = 20.0f;
      startPosition = transform.position;
    }
    void Update()
    {
      aggro();
      if (m_IsAggro == true)
      {
        FollowPlayer(player.transform.position);
      }
    }
    public override void  FollowPlayer(Vector3 destination)
    {
      TurnTowards(destination);
    }
}
