﻿using APIBoletim.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Interfaces
{
    interface IAluno
    {
        List<Aluno> LerTodos();
        Aluno BuscarPorId(int id);
        Aluno Cadastrar(Aluno a);
        Aluno Alterar(int id, Aluno a);
        void Excluir(int id);
    }
}
