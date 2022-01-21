using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE
//Inherits from enemy class
public class Nemesis_Controller : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.Find("Player");
      startPosition = transform.position;
      m_AggroDistance = 17.5f;
    }

    // Update is called once per frame
    void Update()
    {
      aggro();
      if (m_IsAggro == true)
      {
        FollowPlayer(player.transform.position);
      }
    }
    //POLYMORPHISM
    //Function overrides to never stop chasing the player once aggroed
    public override void aggro()
    {
      if (Vector3.Distance(transform.position,player.transform.position) < m_AggroDistance)
      {
        m_IsAggro = true;
      }
    }

}
