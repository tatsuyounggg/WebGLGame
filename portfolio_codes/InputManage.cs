using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManage : MonoBehaviour
{
  public InputField inputField;
  public Text text;
  public Text placeHolder;

  void Start () {
      inputField = inputField.GetComponent<InputField> ();
      gameObject.GetComponent<InputField>().placeholder.GetComponent<Text>().text = GameDirector.clear.ToString();
      text = text.GetComponent<Text> ();
    }
    public void InputText(){
           text.text = inputField.text;
           GameDirector.clear = int.Parse(text.text);
    }
}
