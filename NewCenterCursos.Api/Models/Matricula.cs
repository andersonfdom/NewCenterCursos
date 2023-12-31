﻿using System;
using System.Collections.Generic;

namespace NewCenterCursos.Api.Models
{
    public partial class Matricula
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Datanascimento { get; set; }
        public string? Rg { get; set; }
        public string? Cpf { get; set; }
        public string? Curso { get; set; }
        public string? Whatsapp { get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public string? Email { get; set; }
        public string? Nomeresponsavel { get; set; }
        public string? Telefoneresponsavel { get; set; }
        public string? Nomemae { get; set; }
        public DateTime? Datacadastro { get; set; }
    }
}
