using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        GameManager.Instance.PlusScore();
        Destroy(gameObject);
    }
}
