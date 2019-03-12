using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodo : MonoBehaviour
{
    public GameObject[] lista_vecinos;


	// Use this for initialization
	void Awake ()
    {
        int ind = 0;
        lista_vecinos = new GameObject[50];
        GameObject[] aux;
        aux =GameObject.FindGameObjectsWithTag("Player");

        for (int i=0; i< aux.Length;i++)
        {
            if (Vector3.Distance(this.gameObject.transform.position, aux[i].transform.position)<8)
            {
                lista_vecinos[ind++] = aux[i];
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
