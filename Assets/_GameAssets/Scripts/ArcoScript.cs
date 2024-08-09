using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcoScript : MonoBehaviour {

    [SerializeField] Transform genPoint;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] int force = 600;

    AudioSource audioSource;
  
    // Use this for initialization
    void Start() {
        // RECOGER EL SONIDO
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {

    }

    // cuando pulsemos con el raton encima de nuestro Arco disparara
    private void OnMouseDown() {
        GameObject proyectil = Instantiate(prefabProyectil,
                                genPoint.transform.position,
                                genPoint.transform.rotation);

        // SONIDO
        audioSource.Play();

        //LE AÑADIMOS LA FUERZA
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
    }

    
}


