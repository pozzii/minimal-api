﻿using minimal_api.Dominio.DTOs;
using minimal_api.Dominio.Entidades;

namespace minimal_api.Infraestrutura.Interfaces;

public interface IAdmistradorServico
{
    Administrador? Login(LoginDTO loginDTO);
    Administrador? Incluir(Administrador administrador);
    Administrador? BuscaPorId(int id);

    List<Administrador> Todos(int? pagina);


}