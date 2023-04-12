using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class money : MonoBehaviour
{
  [SerializeField] int Money;

  public Text MoneyText;

  public void OnClickButton()
  {
    Money++;
  }

  private void Update()
  {
    MoneyText.text = Money + "$";
  }
}
