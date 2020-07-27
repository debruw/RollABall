using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deneme : MonoBehaviour
{
    public int x, y;
    // Değişken tanımlama kuralı
    // erişilebilirlik + değişken türü + değişken ismi
    //  public
    //  private
    //  protected

    //  int // tam sayı
    //  float // virgüllü sayı
    //  string // kelimeler harfer karakterler
    //  bool // True ve false
    //  GameObject
    //  Animation
    //  var 

    // Fonksiyon tanımlama kuralı
    // erişebilirlik + dönecek değişken türü + fonksiyon ismi+ (parameteler) + { ana blok }
    // void geriye değer döndürmez

    Image image;

    private void Start()
    {
        int deger = 5;
        Debug.Log(toplama(x, y));
        Debug.Log(deger);
    }

    public int toplama(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}