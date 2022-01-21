using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter_Controller : Enemy
{
  public virtual void Start()
  {
    player = GameObject.Find("Player");
    startPosition = transform.position;
  }

  void Update()
  {
    aggro();
    if (m_IsAggro == true)
    {
      FollowPlayer(player.transform.position);
    } else if (transform.position != startPosition){
      FollowPlayer(startPosition);
    }
  }
}
