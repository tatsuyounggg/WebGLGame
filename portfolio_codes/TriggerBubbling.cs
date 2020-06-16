using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBubbling : MonoBehaviour
{
    public bool call_enter;
    public bool call_exit;

    private GameObject Parent;

    void Start () {
        Parent = transform.parent.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D c) {
        if (call_enter) {
            Parent.SendMessage("OnChildTriggerEnter2D", c);
        }
    }

    private void OnTriggerExit2D(Collider2D c) {
        if (call_exit) {
            Parent.SendMessage("OnChildTriggerExit2D", c);
        }
    }
}
