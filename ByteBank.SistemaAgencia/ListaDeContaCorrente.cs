﻿using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    // [item][item][item][item][item]
    //                                ^
    //                                 `- _proximaPosicao


    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }


        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if(_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando capacidade da lista!");

            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for(int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                Console.WriteLine(".");
            }

            _itens = novoArray;
        }



    }
}
