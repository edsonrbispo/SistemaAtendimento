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

                    //Início Cabeçalho
                    page.Header().BorderBottom(1).PaddingBottom(10).Row(row => {

                        row.RelativeItem(1).Column(col => {
                            string logoPath = Path.Combine(AppContext.BaseDirectory,"Assets","logotiposenac.png");
                            if (File.Exists(logoPath))
                            {
                                col.Item().Width(80).Image(logoPath);
                            }
                            else
                            {
                                col.Item().Text("SENAC").FontSize(14).Bold();
                            }
                        });

                        row.RelativeItem(1).AlignCenter().AlignMiddle().Text("Lista de Clientes").FontSize(16).Bold();

                        row.RelativeItem(1).AlignRight().AlignMiddle().Text(t => { 
                            t.Span("Data: ").Bold();
                            t.Span(DateTime.Now.ToString("dd/MM/yyyy"));                          
                        });
                    
                    });

                    //Conteúdo Central
                    //page.Content().PaddingVertical(10).Table(table => { });


                    //Rodapé
                    page.Footer().AlignCenter().Text(t => {
                        t.Span("Página ");
                        t.CurrentPageNumber();
                    });

                });
            
            }).GeneratePdf(caminho);
        
            return caminho;
        }
    }
}
