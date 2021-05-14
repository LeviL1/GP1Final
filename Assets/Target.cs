using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Target : MonoBehaviour
{
  public float health = 50f;
  private NavMeshAgent agent;
  public GameObject player;
  public float damage = 15;
  private float nextAttackTime = 0f;
  public float attackRate = 1;
  // Start is called before the first frame update

  private void Start()
  {
    agent = GetComponent<NavMeshAgent>();
  }
  // Update is called once per frame
  void Update()
    {
        if(health <= 0)
    {
      Destroy(this.gameObject);
    }
    agent.SetDestination(player.transform.position);
    if (agent.remainingDistance <= 7 && Time.time > nextAttackTime)
    {
      nextAttackTime = Time.time + attackRate;
      StartCoroutine(AttackRoutine());
    }
  }
  
  public void TakeDamage(float dmg)
  {
    health -= dmg;
  }
  IEnumerator AttackRoutine()
  {
    
      yield return new WaitForSeconds(0.25f);

    player.GetComponent<PlayerHealth>().TakePlayerDamage(damage);
    yield return new WaitForSeconds(3f);
      
    
  }


}
