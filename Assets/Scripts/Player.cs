using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public enum ETeams {TeamA , TeamB}
public class Player : MonoBehaviour
{
    public Atribute hp = new Atribute(3);
    public ETeams team;
    public GameObject turnIndicator;
    public TextMeshPro indicatorLife;
   
    public void NotifyShootComplete(Proyectil proyectil)
    {
        OnTurnFinish();
    }
    public void ApplyDamage(float Damage)
    {
        hp.RestToValue(Damage);
        
    }

    public void OnTurnBeggin()
    {
        GetComponent<Throw>().CanAttack = true;
        turnIndicator.SetActive(true);
    }
    public void OnTurnFinish()
    {
        GetComponent<Throw>().CanAttack = false;
        StartCoroutine(WaitForEndOfTurn());
        turnIndicator.SetActive(false);


    }
    IEnumerator WaitForEndOfTurn()
    {
        yield return new WaitForSeconds(2.5f);
        GameManager.instance.SetNextTurn();
    }
    private void Update()
    {
        if(hp.currentValue <= 0)
        {
            Destroy(gameObject);
        }
        indicatorLife.SetText(hp.currentValue.ToString("0"));

    }
}
