using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    public GameObject[] arrayizquierda;
    public GameObject[] arrayderecha;
    public Text precio1;
    public Text precio2;
    public InputField input;
    public GameObject cerrar;
    public GameObject seguir;
    public GameObject salir;
    public Text textopanel;
    public GameObject panel;
    public Text buttontext;
    int x;
    int y;

    void Start()
    {
        input.text = "";
        
        foreach(GameObject producto in arrayderecha)
        {
            producto.SetActive(false);
        }
        foreach (GameObject producto in arrayizquierda)
        {
            producto.SetActive(false);
        }
        x = Random.Range(0, arrayderecha.Length);
        arrayderecha[x].SetActive(true);
        y = Random.Range(0, arrayizquierda.Length);
        arrayizquierda[y].SetActive(true);
        precio1.text = "$" + arrayizquierda[y].GetComponent<Producto>().precio.ToString();
        precio2.text = "$" + arrayderecha[x].GetComponent<Producto>().precio.ToString();
        panel.SetActive(false);
        cerrar.SetActive(false);
        seguir.SetActive(false);
        salir.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void check(){
        if(input.text == ""){
            panel.SetActive(true);
            textopanel.text = "Ingrese un valor";
            cerrar.SetActive(true);
        }
        else if(int.Parse(input.text) == arrayizquierda[y].GetComponent<Producto>().precio + arrayderecha[x].GetComponent<Producto>().precio){
            panel.SetActive(true);
            textopanel.text = "Correcto";
            salir.SetActive(true);
            seguir.SetActive(true);
            buttontext.text = "Reiniciar desafio";
        }
        else{
            panel.SetActive(true);
            textopanel.text = "Incorrecto";
            salir.SetActive(true);
            seguir.SetActive(true);
            buttontext.text = "Volver a intentarlo";
        }
    }

    public void cerrarpanel(){
        panel.SetActive(false);
        cerrar.SetActive(false);
    }

    public void seguirjugando(){
        salir.SetActive(false);
        seguir.SetActive(false);
        Start();
    }

    public void salirjuego(){
        UnityEditor.SceneManagement.EditorSceneManager.LoadScene("SeleccionarJuegos");
    }



}
