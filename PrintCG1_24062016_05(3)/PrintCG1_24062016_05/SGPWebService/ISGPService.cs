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
        List<DataClass.PriceList> calPrice(int Quantity, float Weight, string ProvinceID, string CustomerID, string ServiceType, float Price);
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
        bool addCustomer(string noigui, string socg, string sochungtuthuve, string sochungtulienquan, string deliverydate, string nodename, string shiptoaddress, string province, string zone, string customerid, string date, string hour, string staff, string note,string buucuc);
        [OperationContract]
        List<DataClass.SpeCustomer> getSpCustomer(string buucuc, string employee, string fromdate, string todate, int type);
        [OperationContract]
        List<DataClass.SpCustomer> getCustomerID();
        [OperationContract]
        bool changeCustomer(int id, string date, string hour, string deliveryto);
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
        [OperationContract]
        List<DataClass.ChiTietHoaDon> getChiTietHoaDonAll();
        [OperationContract]
        List<DataClass.Customers> getCustomerIDbyPost(string PostOfficeID);
        [OperationContract]
        List<DataClass.CustomerGroup> getCustomerGroup();
        [OperationContract]
        List<DataClass.Customers> getCustomerIDbyGroup(string GroupID);
        [OperationContract]
        List<DB.TB_DHLPlan> getDHLplan(DateTime FromDate, DateTime ToDate);
        [OperationContract]
        bool updateMailerDeliveryDetail(string mailerid, DateTime ngaygio, string nguoinhan, string trangthai);
        [OperationContract]
        List<DataClass.getCustomerIDTab4> getCustomerIDTab4(string postofficeid);
        [OperationContract]
        List<DataClass.getCustomerGroupTab4> getCustomerGroupTab4();
        [OperationContract]
        List<DataClass.getListSpCustomer> getListSpCustomer(string tungay, string denngay, string customerid, string buucuc, int loai);
        [OperationContract]
        List<DataClass.CGChuaNhapDT> getListCGChuaNhapDT(string tungay, string denngay, string buucuc);
        [OperationContract]
        List<DataClass.CGChuaNhapDT> getListCGChuaXuatBK(string tungay, string denngay, string buucuc);
        [OperationContract]
        List<DataClass.getPostOffice> getPostOffice();
        [OperationContract]
        List<DataClass.ZoneList> getZone();
        [OperationContract]
        List<DB.MM_CustomerGroup> getCustomerGroupPMS();
        [OperationContract]
        List<DataClass.getListSpCustomer> getListCustomerGroupDetails(string tungay, string denngay, string parameter,string customergroup,int loai);
        [OperationContract]
        List<DataClass.SpeCustomer> getMailerCustomerList(string buucuc, string employee, string fromdate, string todate, int type);
        [OperationContract]
        bool insert_DocumentReturn(string DocumentID,DateTime DocumentDate,string POD,string PostOfficeID);
        [OperationContract]
        List<DataClass.DocumentReturn> get_DocumentReturn(DateTime tungay, DateTime denngay, string buucuc);
        [OperationContract]
        bool delete_DocumentReturn(string POD, string PostOfficeID);
        [OperationContract]
        List<DataClass.DocumentReturn> get_DocumentReturnbyPOD( string pod);
     
    }
}
