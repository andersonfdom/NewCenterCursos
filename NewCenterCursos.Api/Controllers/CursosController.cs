
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewCenterCursos.Api.ModelCursos;
using System.Net;

namespace NewCenterCursos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {
        [HttpPost]
        public void ListarCursos(string host, [FromBody] List<ApiEscolaAvancadaCurso> lista)
        {

            foreach (var item in lista)
            {
                try
                {
                    using (NewCenterCursosSiteContext ctx = new NewCenterCursosSiteContext())
                    {
                        var dadosCurso = ctx.WpPosts.FirstOrDefault(c => c.PostTitle == item.nome);

                        if (dadosCurso == null)
                        {

                            WpPost post = new WpPost
                            {
                                PostAuthor = 1,
                                PostDate = DateTime.Now,
                                PostDateGmt = DateTime.Now,
                                PostContent = FormatarDescricaoCurso(item),
                                PostTitle = item.nome,
                                PostExcerpt = "",
                                PostStatus = "publish",
                                CommentStatus = "closed",
                                PingStatus = "open",
                                PostPassword = "",
                                PostName = removerAcentos(System.Web.HttpUtility.UrlDecode(item.nome).Replace(" ", "-").ToLower()),
                                ToPing = "",
                                Pinged = "",
                                PostModified = DateTime.Now,
                                PostModifiedGmt = DateTime.Now,
                                PostContentFiltered = "",
                                PostParent = 0,
                                MenuOrder = 0,
                                PostType = "post",
                                PostMimeType = "",
                                CommentCount = 0
                            };

                            ctx.WpPosts.Add(post);
                            ctx.SaveChanges();

                            post.Guid = $"http://localhost/newcentercursos/?p={post.Id.ToString()}";
                            ctx.SaveChanges();

                            WpPost imagens = new WpPost
                            {
                                PostAuthor = 1,
                                PostDate = DateTime.Now,
                                PostDateGmt = DateTime.Now,
                                PostContent = "",
                                PostTitle = "",
                                PostExcerpt = "",
                                PostStatus = "inherit",
                                CommentStatus = "",
                                PingStatus = "closed",
                                PostPassword = "",
                                PostName = "",
                                ToPing = "",
                                Pinged = "",
                                PostModified = DateTime.Now,
                                PostModifiedGmt = DateTime.Now,
                                PostContentFiltered = "",
                                PostParent = post.Id,
                                MenuOrder = 0,
                                PostType = "attachment",
                                PostMimeType = "image/jpeg",
                                CommentCount = 0,
                                Guid = item.capa_image
                            };

                            ctx.WpPosts.Add(imagens);
                            ctx.SaveChanges();

                            WpPostmetum metaThumbnailId = new WpPostmetum
                            {
                                PostId = post.Id,
                                MetaKey = "_thumbnail_id",
                                MetaValue = imagens.Id.ToString()
                            };

                            ctx.WpPostmeta.Add(metaThumbnailId);
                            ctx.SaveChanges();

                            WpPostmetum metaWpAttachedFile = new WpPostmetum
                            {
                                PostId = imagens.Id,
                                MetaKey = "_wp_attached_file",
                                MetaValue = item.capa_image.Replace("https://estudandoead.com/newcentercursos/", "")
                            };

                            ctx.WpPostmeta.Add(metaWpAttachedFile);
                            ctx.SaveChanges();

                            if (host == "localhost")
                            {
                                using (WebClient client = new WebClient())
                                {
                                    string path = @"D:\xampp\htdocs\newcentercursos\wp-content\uploads\metodo\imagemcursos\" + item.capa_image.Replace("https://estudandoead.com/newcentercursos/metodo/imagemcursos/", "");

                                    client.DownloadFile(new Uri(item.capa_image), path);
                                }
                            }

                        }

                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private string MontarParagrafo(string campo)
        {
            return $"<p>{campo}</p><br />";
        }

        private string MontarParagrafoNegrito(string campo)
        {
            return $"<p><em>{campo}</em></p><br />";
        }

        private string FormatarDescricaoCurso(ApiEscolaAvancadaCurso curso)
        {
            string formato = "";

            formato += $"<img src='{curso.capa_image}' width=300 height=300 /><br />";

            formato += MontarParagrafo(curso.obs);
            formato += MontarParagrafoNegrito("Categoria Curso");
            formato += MontarParagrafo(curso.categoria_interna);
            formato += MontarParagrafoNegrito("Carga Horária");
            formato += MontarParagrafo(curso.carga_horaria);


            return formato;
        }

        private string removerAcentos(string texto)
        {
            string Acentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < Acentos.Length; i++)
            {
                texto = texto.Replace(Acentos[i].ToString(), semAcentos[i].ToString());
            }
            return texto;
        }
    }

    public class ApiEscolaAvancadaCurso
    {
        public string nome { get; set; }
        public string aulas { get; set; }
        public string preco { get; set; }
        public string preco_promocional { get; set; }
        public string parcelas { get; set; }
        public string status { get; set; }
        public string obs { get; set; }
        public string categoria_interna { get; set; }
        public string carga_horaria { get; set; }
        public string categoria_loja { get; set; }
        public string destaque { get; set; }
        public string preco_mostrar { get; set; }
        public string capa_image { get; set; }
    }
}
