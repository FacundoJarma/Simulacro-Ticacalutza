using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TICapalooza : MonoBehaviour
{
    public int entradasCampoVendidas;
    public int entradasPlateasVendidas;

    int CapacidadPredio = 36600;
    int CapacidadMaximaPlateas = 16200;
    int CapacidadMaximaCampo = 20400;
    int PrecioEntradaCampo = 1200;
    int PrecioEntradaPlatea = 1200;

    void Start()
    {

        if(entradasCampoVendidas < 0 || entradasPlateasVendidas < 0 || entradasPlateasVendidas > CapacidadMaximaPlateas || entradasCampoVendidas > CapacidadMaximaCampo){
            Debug.Log("[-] Ingresa una cantidad de entradas valida.");
            return;
        }

        int recaudacionCampo = entradasCampoVendidas * PrecioEntradaCampo;
        int recaudacionPlateas = entradasPlateasVendidas * PrecioEntradaPlatea;
        Debug.Log("[!] En campo se recaudo un total de: " + recaudacionCampo + "$");
        Debug.Log("[!] En plateas se recaudo un total de: " + recaudacionPlateas + "$");
        Debug.Log("[!] En total se recaudo: " + (recaudacionPlateas + recaudacionCampo) + "$");

        int totalVendidas = (entradasCampoVendidas + entradasPlateasVendidas);
        int lugaresRestantes = CapacidadPredio - totalVendidas;
        if(lugaresRestantes == 0){
            Debug.Log("[!] Hubo sold out.");
        }
        else{
            Debug.Log("[!] Quedaron vacantes: " + lugaresRestantes + " lugares.");
        }

        if(totalVendidas > CapacidadPredio/2){
            Debug.Log("[+] El festival fue un exito!!");
        }
        else{
            Debug.Log("[-] Debemos mejorar la convocatoria.");
        }

    }
}
