using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcoScript : MonoBehaviour {

    [SerializeField] Transform genPoint;
    [SerializeField] GameObject prefabProyectil;
    [SerializeField] int force = 600;

  
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    // cuando pulsemos con el raton
    private void OnMouseDown() {
        GameObject proyectil = Instantiate(prefabProyectil,
                                genPoint.transform.position,
                                genPoint.transform.rotation);

        //LE AÑADIMOS LA FUERZA
        proyectil.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * force);
    }

    
}


