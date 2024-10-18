using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    [SerializeField]
    Wallet myWallet;
    //[SerializeField]
    //TextMeshProUGUI ;
    TextMeshProUGUI textButton;
    [SerializeField]
    string[] posiblesNombres;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    // Start is called before the first frame update
    void Start()
    {
        nameItem = posiblesNombres[Random.Range(0,posiblesNombres.Length)];
        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = nameItem + "\n" + priceItem.ToString() + " $";
    }

    public void ClickEnBotonDeTienda()
    {
        myWallet.InformarCompra(nameItem, priceItem);
    }
}
