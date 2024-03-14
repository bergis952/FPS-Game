using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
      public GameObject Money;
      public int Income = 10;
      public int ICMAX;
      public int playerMoney = 0;
      private int IncomeCounter = 0;
      public int KillCount = 0;

      void Start()
      {
            var mousePos = Input.mousePosition;
            mousePos.x -= Screen.width/2;
            mousePos.y -= Screen.height/2;
            Cursor.lockState = CursorLockMode.Locked;
            UpdateMoney();
      }

      void Update()
      {
            if (IncomeCounter < ICMAX)
            {
                  IncomeCounter += 1;
            }
            else
            {
                  AddScore(Income);
                  IncomeCounter = 0;
            }
      }

      public void AddScore(int points)
      {
            playerMoney += points;
            UpdateMoney();
      }

      void UpdateMoney()
      {
            TextMesh MoneyB = Money.GetComponent<TextMesh>();
            MoneyB.text = "$" + playerMoney;
      }
}
