using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject[] arrayproductos;
    void Start()
    {
        foreach(GameObject producto in arrayproductos)
        {
            producto.SetActive(false);
        }
        int x = Random.Range(0, arrayproductos.Length - 1);
        arrayproductos[x].SetActive(true);
        x = Random.Range(0, arrayproductos.Length - 1);
        arrayproductos[x].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
