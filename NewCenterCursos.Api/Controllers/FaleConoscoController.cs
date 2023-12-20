using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewCenterCursos.Api.Models;

namespace NewCenterCursos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaleConoscoController : ControllerBase
    {
        ConfigEmail mailUtils = new ConfigEmail();

        [HttpPost]
        public string EnviarFaleConosco([FromBody] FaleConoscoModel model)
        {
            string retorno = string.Empty;

            bool emailEnviado = mailUtils.EmailEnviado(model.Email, "Cadastro Fale Conosco site newcentercursos.com.br Nome: " +
                             model.Nome + " Cidade: " + model.Cidade +
                             " Estado: " + model.Estado +
                             " Assunto: " + model.Assunto, MontarCorpoEmail(model), " envio e-mail menu Fale Conosco");

            try
            {
                using (NewCenterCursosApiContext ctx = new NewCenterCursosApiContext())
                {
                    Faleconosco f = new Faleconosco
                    {
                        Nome = model.Nome,
                        Telefone = model.Telefone,
                        Celular = model.Celular,
                        Email = model.Email,
                        Cidade = model.Cidade,
                        Estado = model.Estado,
                        Assunto = model.Assunto,
                        Mensagem = model.Mensagem,
                    };

                    ctx.Faleconoscos.Add(f);
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

        private string MontarCorpoEmail(FaleConoscoModel model)
        {
            string layoutEmail = string.Empty;


            layoutEmail += mailUtils.GetItemLabelValueEmail("Data do Cadastro", Convert.ToDateTime(DateTime.Now.ToShortDateString()).ToString("dd/MM/yyyy") + " " +
                                                                                 Convert.ToDateTime(DateTime.Now.ToShortTimeString()).ToString("HH:mm:ss"));
            layoutEmail += mailUtils.GetItemLabelValueEmail("Nome", model.Nome);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Telefone", model.Telefone);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Celular", model.Celular);
            layoutEmail += mailUtils.GetItemLabelValueEmail("E-mail", model.Email);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Cidade", model.Cidade);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Estado", model.Estado);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Assunto", model.Assunto);
            layoutEmail += mailUtils.GetItemLabelValueEmail("Mensagem", "\r\n" + model.Mensagem);

            var email = mailUtils.GetBodyEmail(
                "Cadastro Fale Conosco site newcentercursos.com.br Nome: " +
                                        model.Nome + " Cidade: " + model.Cidade +
                                        " Estado: " + model.Estado, layoutEmail);


            return email;
        }
    }

    public class FaleConoscoModel
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Assunto { get; set; }
        public string Mensagem { get; set; }
    }
}
