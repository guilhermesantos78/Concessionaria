﻿
using Entidades;

namespace Core
{
    public interface ICaminhaoService
    {
        void Adicionar(Caminhao caminhao);
        void Remover(int id);
        void Editar(Caminhao caminhao);
        List<Caminhao> Listar();
        Caminhao BuscarPorId(int id);
    }
}
