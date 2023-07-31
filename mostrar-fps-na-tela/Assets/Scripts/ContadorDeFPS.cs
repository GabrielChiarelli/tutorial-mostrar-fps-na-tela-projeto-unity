using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorDeFPS : MonoBehaviour
{
    [Header("Contador")]
    [SerializeField] private float taxaDeAtulizacaoDoContador;
    private float quantidadeDeFPS;

    [Header("UI")]
    [SerializeField] private Text textoDoContadorDeFPS;

    private void Start()
    {
        InvokeRepeating(nameof(ContarFPSDoJogo), 0f, taxaDeAtulizacaoDoContador);
    }

    private void ContarFPSDoJogo()
    {
        quantidadeDeFPS = 1f / Time.deltaTime;
        textoDoContadorDeFPS.text = Mathf.Floor(quantidadeDeFPS).ToString() + " FPS";
    }
}
