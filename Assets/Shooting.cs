using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
  public float dmg;
  public float fireRate;

  private ParticleSystem system;
  public GameObject impactEffect;
  private float nextTimeToFire = 0f;
  public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
    system = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
    {
      nextTimeToFire = Time.time + 1f / fireRate;
      Shoot(dmg);
    }
    }
  void Shoot(float damage)
  {
    
    system.Play();
    RaycastHit hit;
    if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, Mathf.Infinity))
    {
      Target target = hit.transform.GetComponent<Target>();
      if(target != null)
      {
        target.TakeDamage(damage);
      }
    }
  }
}
