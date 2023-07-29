using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Movimientos : MonoBehaviour
{
    public float velocidadCorrer = 2;
    public float velocidadSaltar = 3;
    Rigidbody2D rb2D;
    public int Entorno = 0;
     [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    

    public Button btnleft, btnRight;
    void Start()
    {
        rb2D =GetComponent<Rigidbody2D>();
    }
    public void irDercha()
    {
        rb2D.velocity= new Vector2(velocidadCorrer,rb2D.velocity.y);
    }

    public void irIzquierda()
    {
        rb2D.velocity= new Vector2(-velocidadCorrer,rb2D.velocity.y);

        //btnleft = new Quaternion(0,180f,0,0); 
    }

    public void Saltar()
    {
        rb2D.velocity= new Vector2(rb2D.velocity.x,velocidadSaltar);
    }

    private void OnTriggerEnter2D(Collider2D collision)         
 {
    if (collision.gameObject.tag == "Entorno")
    {
        
        Entorno++;
        Destroy(collision.gameObject);
        puntaje.SumarPuntos(cantidadPuntos);
    }
    
    if (collision.gameObject.tag == "lobo")
    {
       Entorno--;
        Destroy(collision.gameObject);
        puntaje.RestarPuntos(cantidadPuntos);  
    }


    
 }

    
}