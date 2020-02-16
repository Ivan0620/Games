using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem fireEffect;
    public GameObject Effect;


    void Start()
    {
        fpsCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }

    void Shoot()
    {
        fireEffect.Play();

        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Target target = hit.transform.GetComponent<Target>();
            if(target!=null)
            {
                Debug.Log(hit.transform.name);
                target.TakeDamage(damage);
            }
            GameObject obj = Instantiate(Effect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(obj, 0.2f);
        }
    }
}
