using ClosedXML.Excel;

namespace ExceleRaptor.ClosedXML
{
    public class ClosedXMLSpreadsheetAdapter : ISpreadsheetAdapter
    {
        private XLWorkbook _wb;

        public void SetTemplate(string pathToTemplate)
        {
            _wb = new XLWorkbook(pathToTemplate);
        }
    }
}
