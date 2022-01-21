using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
//base class "Enemy" is inherited from
public class Enemy : MonoBehaviour
{
  //ENCAPSULATION
  //initialized variables are encapsulated
    protected float m_MoveSpeed = 1.0f;
    public float MoveSpeed
    {
      get {return m_MoveSpeed;}
      set
      {
        if (value < 0.0f)
        {
          m_MoveSpeed = 0.0f;
        }
        else if (value > 3.0f)
        {
          m_MoveSpeed = 3.0f;
        }
      }
    }
    protected float m_RotateSpeed = 5.0f;
    public float RotateSpeed
    {
      get {return m_RotateSpeed;}
      set
      {
        if (value < 0.0f)
        {
          m_RotateSpeed = 0.0f;
        }
        else if (value >3.0f)
        {
          m_RotateSpeed = 3.0f;
        }
      }
    }
    protected bool m_IsAggro = false;
    public bool IsAggro { get; set;}
    protected float m_AggroDistance = 12.5f;
    public float AggroDistance {get; set;}
    protected float m_GiveUpDistance = 25.0f;
    public float GiveUpDistance {get; set;}
    protected Vector3 startPosition;

    protected GameObject player;
    // Start is called before the first frame update


    // Update is called once per frame
    //ABSTRACTION
    //Turn Towards allows the enemy to turn towards the player
    public virtual void TurnTowards(Vector3 destination)
    {
        Vector3 targetDirection = destination - transform.position;
        float singleStep = m_RotateSpeed * Time.deltaTime;
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection,singleStep,0.0f);
        newDirection.y = 0.0f;
        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    //ABSTRACTION
    // Aggro function automatically tests to see if the enemy should aggro
    public virtual void aggro()
    {
      if (Vector3.Distance(transform.position,player.transform.position) < m_AggroDistance &&
          Vector3.Distance(transform.position,startPosition) < m_GiveUpDistance)
      {
        m_IsAggro = true;
      } else {
        m_IsAggro = false;
      }
    }
    //ABSTRACTION
    // FollowPlayer function will allow enemy to turn player using TurnTowards, then follow player
    //Alternatively, can be used to go back to home location
    public virtual void FollowPlayer(Vector3 destination)
    {
      TurnTowards(destination);
      float step = m_MoveSpeed * Time.deltaTime;
      transform.position = Vector3.MoveTowards(transform.position,destination,step);
    }
}
