using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Atribute 
{
   public float baseValue;
   public float currentValue;

   public Atribute()
    {
        baseValue = currentValue = 1;
    }
    public Atribute(float initialValue)
    {
        baseValue = currentValue = initialValue;
    }

    public float AddToValue(float valueToAdd)
    {
        currentValue = Mathf.Clamp(currentValue + valueToAdd , 0,baseValue);
        return currentValue;

    }

    public float RestToValue(float valueToRest)
    {
        currentValue = Mathf.Clamp(currentValue - valueToRest,0, baseValue);
      
        return currentValue;

    }



}
