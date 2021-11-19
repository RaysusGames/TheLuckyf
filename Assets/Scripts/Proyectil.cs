using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Proyectil : MonoBehaviour
{
    public float initialVelocity = 10;
    public float damage = 1;
    
public void ShootTo(Vector3 Direction)
    {
        ShootWitchForce(Direction,initialVelocity);
    }


    public void ShootWitchForce(Vector3 Direction , float force)
    {
        GetComponent<Rigidbody>().AddForce(Direction*force,ForceMode.Impulse);
        StartCoroutine(RestoreCollision());

    }

    IEnumerator RestoreCollision()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Collider>().isTrigger = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Player>())
        {
            ApplyEffectToPlayer(collision.gameObject.GetComponent<Player>());
        }
        
    }

    public virtual void ApplyEffectToPlayer(Player  player) 
        {
        player.ApplyDamage(damage);
        Destroy(gameObject);
        }
}
