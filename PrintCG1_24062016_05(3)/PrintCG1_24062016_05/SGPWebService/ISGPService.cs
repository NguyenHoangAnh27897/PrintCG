using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SGPWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISGPService" in both code and config file together.
    [ServiceContract]
    public interface ISGPService
    {
        [OperationContract]
        bool login(string user, string pass, string post);
        [OperationContract]
        string getmaxMailerID(string postoffice);
        [OperationContract]
        List<DB.BS_Province> getProvince();
        [OperationContract]
        bool insertSGP_Province_Zones(string ZoneID, string ProvinceID, int Zone);
    }
}
