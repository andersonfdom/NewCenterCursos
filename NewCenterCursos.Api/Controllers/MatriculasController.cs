using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewCenterCursos.Api.Models;

namespace NewCenterCursos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        ConfigEmail mailUtils = new ConfigEmail();

        [HttpPost]
        public string EnviarMatricula([FromBody] MatriculaModel model)
        {
            string retorno = string.Empty;

            bool emailEnviado = mailUtils.EmailEnviado(model.Email, "Matrícula site newcentercursos.com.br Aluno: " +
            model.Nome + " Curso: " + model.Curso, MontarCorpoEmail(model),
            " envio e-mail menu Matricule-se");

            try
            {
                using (NewCenterCursosApiContext ctx = new NewCenterCursosApiContext())
                {
                    Matricula m = new Matricula
                    {
                        Nome = model.Nome,
                        Datanascimento = model.DataNascimento,
                        Rg = model.Rg,
                        Cpf = model.Cpf,
                        Curso = model.Curso,
                        Whatsapp = model.WhatsApp,
                        Cep = model.Cep,
                        Logradouro = model.Logradouro,
                        Complemento = model.Complemento,
                        Bairro = model.Bairro,
                        Cidade = model.Cidade,
                        Estado = model.Estado,
                        Email = model.Email,
                        Nomeresponsavel = model.NomeResponsavel,
                        Telefoneresponsavel = model.TelefoneResponsavel,
                        Nomemae = model.NomeMae
                    };

                    ctx.Matriculas.Add(m);
                    ctx.SaveChanges();

                    retorno = "E-mail enviado com sucesso!";
                }
            }
            catch (Exception)
            {
                retorno = "Falha ao enviar e-mail!";
                return retorno;
            }

            return retorno;
        }

        private string MontarCorpoEmail(MatriculaModel model)
        {
            string layoutEmail = string.Empty;

            layoutEmail += mailUtils.GetItemLabelValueEmail("Data da Matrícula", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("dd/MM/yyyy") + " " +
                                                                                 Convert.ToDateTime(DateTime.Now.ToShortTimeString()).ToString("HH:mm:ss"));

            layoutEmail += mailUtils.GetItemLabelValueEmail("Nome do Aluno", model.Nome);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Data de Nascimento", model.DataNascimento);
            layoutEmail += mailUtils.GetItemLabelValueEmail("RG", model.Rg);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Cpf", model.Cpf);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Curso", model.Curso);
            layoutEmail += mailUtils.GetItemLabelValueEmail("WhatsApp", model.WhatsApp);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Logradouro", model.Logradouro);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Cep", model.Cep);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Complemento", model.Complemento);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Bairro", model.Bairro);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Cidade", model.Cidade);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Estado", model.Estado);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Email", model.Email);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Nome do Responsável", model.NomeResponsavel);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Telefone do Responsável", model.TelefoneResponsavel);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Nome da Mãe", model.NomeMae);

            var email = mailUtils.GetBodyEmail("Matrícula site newcentercursos.com.br Aluno: " + model.Nome, layoutEmail);

            return email;
        }
    }

    public class MatriculaModel
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Curso { get; set; }
        public string WhatsApp { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string NomeResponsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string NomeMae { get; set; }
    }
}
