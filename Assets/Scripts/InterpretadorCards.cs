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
        level.text = "Level: " + carta.level;

        beleza.text = carta.beleza.ToString();
        simpatia.text = carta.simpatia.ToString();
        
        qi.text = "QI: " + carta.QI;
        pix.text = "Pix: " + carta.chavePix;
        insta.text = "Seguidores no insta: " + carta.seguidoresNoInsta;

        dragonCity.text = "Nível no dragon city: " + carta.nivelNoDragonCity;
        altura.text = "Altura: " + carta.altura.ToString();
    }

    // declaração função com parâmetro
    public void TrocarCarta(GeeksCard _carta)
    {
        carta = _carta;
        Interpretar();
    }


}
