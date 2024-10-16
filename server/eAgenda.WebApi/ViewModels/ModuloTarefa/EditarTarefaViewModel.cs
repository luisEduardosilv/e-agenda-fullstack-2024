﻿using eAgenda.Dominio.ModuloTarefa;

namespace eAgenda.WebApi.ViewModels.ModuloTarefa
{
    public class EditarTarefaViewModel
    {
        public string Titulo { get; set; }

        public PrioridadeTarefaEnum Prioridade { get; set; }

        public List<ItemTarefaViewModel> Itens { get; set; }
    }
}
