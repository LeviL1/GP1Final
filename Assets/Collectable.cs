using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
  private int coins = 0;
  public GameObject coin;
  private void OnTriggerStay(Collider other)
  {
    if (other.CompareTag("Player"))
    {


      if (Input.GetKey(KeyCode.F))
      {
        Destroy(coin);
        coins += 1;
      }
    }
  }

  // Update is called once per frame
  void Update()
    {
       
    }
}
