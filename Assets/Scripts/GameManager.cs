using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<Player> playerListA = new List<Player>(); 
    public List<Player> playerListB = new List<Player>();
    public int currentPlayerA = -1;
    public int currentPlayerB = -1;
    public bool switchPlayerTurn;

    private void Awake()
    {
        instance = this;
    }

    public void SetNextTurn()
    {
        switchPlayerTurn = !switchPlayerTurn;
        if (switchPlayerTurn)
        {
            currentPlayerA ++;
            if (currentPlayerA >= playerListA.Count )
            {
                currentPlayerA = 0;
            }
            playerListA[currentPlayerA].OnTurnBeggin();
        }
        else
        {
            currentPlayerB++;
            if (currentPlayerB >= playerListB.Count)
            {
                currentPlayerB = 0;
            }
            playerListB[currentPlayerB].OnTurnBeggin();

        }
    }
    public void GameBeggin()
    {
        SetNextTurn();
    }
    // Start is called before the first frame update
    void Start()
    {
        GameBeggin();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
