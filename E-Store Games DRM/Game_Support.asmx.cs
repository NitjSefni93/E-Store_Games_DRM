using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace E_Store_Games_DRM
{
    /// <summary>
    /// Opis podsumowujący dla Game_Support
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Aby zezwalać na wywoływanie tej usługi sieci Web ze skryptu za pomocą kodu ASP.NET AJAX, usuń znaczniki komentarza z następującego wiersza. 
    // [System.Web.Script.Services.ScriptService]
    public class Game_Support : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Witaj świecie";
        }
    }
}
