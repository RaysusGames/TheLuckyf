using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{ 
  //  public GameObject projectilPrefab;
    public Transform aimDir;
    public bool CanAttack;
    public GameObject[] randomObject;
    public int randomNum;
    private void Awake()
    {

        randomNum = Random.Range(0, 6);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanAttack == false)
        {
            return;
        }

        Shoot();
        AimShooting();
    }



    void AimShooting()
    {
        float v = Input.GetAxis("Vertical");
        aimDir.Rotate(v*-1,0,0,Space.Self);
    }
     
    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject projectil = Instantiate(randomObject[randomNum],aimDir.position , Quaternion.identity);
            projectil.GetComponent<Proyectil>().ShootTo(aimDir.forward);
            CanAttack = false;
            GetComponent<Player>().NotifyShootComplete(projectil.GetComponent<Proyectil>());
        }
    }
    
}
