﻿namespace CarCouts.Dominio.Entidades
{
    public class Carro
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string EnderecoImagem { get; set; }
    }
}