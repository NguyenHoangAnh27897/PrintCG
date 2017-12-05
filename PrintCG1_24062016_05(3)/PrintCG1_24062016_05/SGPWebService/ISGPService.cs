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
        [OperationContract]
        List<DB.MM_ServiceType> getServiceType();
        [OperationContract]
        List<DB.MM_Customer> getCustomer(string PostOfficeID);
        [OperationContract]
        List<DataClass.ZoneList> getZoneList();
        [OperationContract]
        int getmaxZone(string ZoneID);
        [OperationContract]
        bool insertSGP_Price_Policy(string PriceID, string PostOfficeID,string Type,DateTime CreateDate,int Status,int Service,string Description,string ZoneID,string CalPrice);
        [OperationContract]
        bool insertSGP_Price_Customer(string PriceID, string CustomerID);
        [OperationContract]
        bool insertSGP_Price_Service(string PriceID, string ServiceID);
        [OperationContract]
        bool insertSGP_Price_Value(string PriceID, float FW,float TW,int Zone,float Price,int CalType,int RowIndex,int ColumnIndex);
        [OperationContract]
        List<DB.SGP_Price_Policy> getPricePolicy();
        [OperationContract]
        List<DB.SGP_Price_Customer> getPriceCustomer(string PriceID);
        [OperationContract]
        List<DB.SGP_Price_Service> getPriceService(string PriceID);
        [OperationContract]
        List<DB.SGP_Price_Value> getPriceValue(string PriceID);
        [OperationContract]
        List<DB.SGP_Price_Service_Value> getPriceServiceValue(string PriceID);
        [OperationContract]
        List<DataClass.PriceList> calPrice(int Quantity, float Weight,string ProvinceID,string CustomerID,string ServiceType);
        [OperationContract]
        List<DB.Tools_Tracking> getUserTrackingProfile(string User);
        [OperationContract]
        List<DataClass.Trackings> ToolTracking(string MailerID);
        [OperationContract]
        List<DataClass.MailerPPNT> getMailer(string MailerID);
        [OperationContract]
        List<DataClass.District> getDisitrct(string ProvinceID);
        [OperationContract]
        bool insertSGP_ChiPhi(string ctvphat, DateTime ngay,string cg, double tl, string lh, string noiden,double cptt,double cpnt,string bcchapnhan,string khachang,double cuoc,double phuphi,string quan,DateTime ngaynhan,string tinh,string bcnhan);
        [OperationContract]
        List<DB.SGP_ChiPhi> getCPNT(DateTime FromDate,DateTime ToDate,int type,string Post);
        [OperationContract]
        bool addCustomer(string noigui, string socg, string sochungtuthuve, string sochungtulienquan, string deliverydate, string nodename, string shiptoaddress, string province, string zone, string customerid, string date, string hour, string staff, string note);
        [OperationContract]
        List<DataClass.SpecialCustomer> getSpCustomer();
        [OperationContract]
        List<DataClass.SpCustomer> getCustomerID();
        [OperationContract]
        bool changeCustomer(int id, string noigui, string socg, string sochungtuthuve, string sochungtulienquan, string deliverydate, string nodename, string shiptoaddress, string province, string zone, string customerid, string date, string hour, string staff, string note);
        [OperationContract]
        bool addCustomerID(string zoneid, string customerid, string customername);
        [OperationContract]
        bool addChiTietHoaDon(string soCT, DateTime createdate, string soCG, int cuocDV, int vat, int total, string tenhanghoa);
        [OperationContract]
        bool addHoaDon(string soCT, string soHD, DateTime createdate);
        [OperationContract]
        List<DataClass.HoaDon> getHoaDon(DateTime Fromdate, DateTime Todate);
        [OperationContract]
        List<DataClass.ChiTietHoaDon> getChiTietHoaDon(string soCT);
        [OperationContract]
        string getPostOfficeName(string postofficeid);
        [OperationContract]
        string getUserName(string userid);
    }
}
