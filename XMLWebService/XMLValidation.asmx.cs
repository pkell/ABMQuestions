using Parsing;
using System.Web.Services;

namespace XMLWebService
{
    /// <summary>
    /// Summary description for XMLValidation
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class XMLValidation : WebService
    {
        [WebMethod]
        public int ValidateXML(string xml)
        {
                return XMLValidator.Validate(xml);
        }
    }
}
