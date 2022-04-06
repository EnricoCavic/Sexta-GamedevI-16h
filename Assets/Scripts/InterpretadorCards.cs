using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterpretadorCards : MonoBehaviour
{

    public GeeksCard carta;

    public Text nome, level, beleza, simpatia, qi, pix, insta, dragonCity, altura;
    

    // Start is called before the first frame update
    void Start()
    {
        Interpretar();      
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Interpretar()
    {
        nome.text = carta.name;
        level.text += " " + carta.level;

        beleza.text = carta.beleza.ToString();
        simpatia.text = carta.simpatia.ToString();
        
        qi.text += " " + carta.QI;
        pix.text += " " + carta.chavePix;
        insta.text += " " + carta.seguidoresNoInsta;

        dragonCity.text += " " + carta.nivelNoDragonCity;
        altura.text += " " + carta.altura.ToString();
    }

    // declaração função com parâmetro
    public void TrocarCarta(GeeksCard _carta)
    {
        carta = _carta;
        Interpretar();
    }


}
