using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSigue : MonoBehaviour
{
    public float rangoDeAlerta;
    public LayerMask capaDelJugador;
    bool estarAlerta;
    public Transform Personaje1;
    public float velocidad;
    private Animator animacion;
    // Start is called before the first frame update
    void Start()
    {
        Personaje1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

       estarAlerta = Physics.CheckSphere(transform.position, rangoDeAlerta, capaDelJugador);

        if (estarAlerta==true)
        {
            animacion.SetBool("Llego", true);
            transform.LookAt(Personaje1);
            transform.position = Vector3.MoveTowards(transform.position, Personaje1.transform.position, velocidad * Time.deltaTime);

        }else
        {
            animacion.SetBool("Llego", false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, rangoDeAlerta);
    }
}
