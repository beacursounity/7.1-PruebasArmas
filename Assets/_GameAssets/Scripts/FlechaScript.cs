using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlechaScript : MonoBehaviour {

    // POSICION ACTUAL DE LA FLECHA
    Vector3 currentPos;
    // POSICION PREVIA
    Vector3 prevPos;
    // DIFERENCIA ENTRE POSICION ANTERIOR Y ACTUAL
    Vector3 difPos;

    bool primeraVez = true;


    // COGEMOS LA POSICION ACTUAL DEL TRANSFORM Y CUANDO SALGO DEL METODO COJO EL ANTERIOR
    // EN ESTE CAS
    private void FixedUpdate() { // CALCULOS FISICOS SE EJECUTA CADA 0,20 
        currentPos = transform.position;
        // SE METERIA YA QUE EL VECTOR3 SE INICIALIZA A 0,0,0
        if(!primeraVez) { 
            difPos = currentPos - prevPos;
            this.transform.forward = difPos.normalized; // EL VECTOR NORMALIZADO ES UNA VECTOR EN BASE 1 
                                // PORQUE TRABAJAMOS EN DIRECCION
        } else{
           primeraVez = false;
        }
        prevPos = currentPos;
    }

    // CUANDO COLISIONA LA FLECHA LE DECIMOS QUE ES KINEMATICO
    // Y DESTRUIMOS EL SCRIPT PARA QUE LA FLECHA NO SE QUEDE RECTA
    private void OnCollisionEnter(Collision collision) {
       // print("ha colisionado "+ collision.gameObject.name);
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        // EL THIS ELIMINA EL SCRIPT
        Destroy(this);
    }
}
