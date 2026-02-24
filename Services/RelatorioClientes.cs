using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Companion;
using SistemaAtendimento.Model;


namespace SistemaAtendimento.Services
{
    public class RelatorioClientes
    {
        public string GerarListaClientes(List<Clientes> listaClientes) { 
        
            QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

            string caminho = Path.Combine(Path.GetTempPath(), $"RelatorioCliente_{Guid.NewGuid()}.pdf");

            Document.Create(container => {

                container.Page(page => {
                    page.Size(PageSizes.A4);
                    page.Margin(1, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x=> x.FontSize(10).FontFamily(Fonts.Verdana));


                    page.Header().BorderBottom(1).PaddingBottom(5).Row(row => { });

                    page.Footer().AlignCenter().Text(t => { });

                });
            
            }).GeneratePdf(caminho);
        
            return caminho;
        }
    }
}
