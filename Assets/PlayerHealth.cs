using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  public float playerHealth = 100f;
    // Start is called before the first frame update
   public void TakePlayerDamage(float dmg)
  {
    playerHealth -= dmg;
  }
  private void Update()
  {
    if(playerHealth <= 0)
    {
      
    }
  }
}
