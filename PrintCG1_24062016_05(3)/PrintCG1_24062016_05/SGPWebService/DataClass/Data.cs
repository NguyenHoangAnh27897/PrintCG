using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGPWebService.DataClass
{
    public class Data
    {
    }
    public class ZoneList
    {
        public string ZoneID { get; set; }
    }
    public class PriceList
    {
        public float Price { get; set; }
        public float PriceService { get; set; }
        public float PPXD { get; set; }
        public float PPHK { get; set; }
    }
    public class Trackings
    {
        public string MM_MailerDeliveryDetail_DeliveryTo { get; set; }
        public DateTime? MM_MailerDeliveryDetail_DeliveryDate { get; set; }
        public DateTime? MM_MailerDeliveryDetail_DeliveryTime { get; set; }
        public string BS_Employees_EmployeeID {get;set;}
        public string BS_Employees_EmployeeName{get;set;}
        public string MM_MailerDelivery_Description{get;set;}
        public DateTime? MM_MailerDelivery_DocumentDate{get;set;}
        public string MM_MailerDelivery_DocumentID{get;set;}
        public DateTime? MM_MailerDelivery_DocumentTime{get;set;}
        public string MM_MailerDelivery_PostOfficeID{get;set;}
        public string MM_MailerDelivery_TripNumber{get;set;}
        public DateTime? MM_MailerDeliveryDetail_ConfirmDate{get;set;}
        public string MM_MailerDeliveryDetail_ConfirmIndex{get;set;}
        public string MM_MailerDeliveryDetail_DeliveryNotes{get;set;}
        public string MM_MailerDeliveryDetail_DeliveryStatus{get;set;}
        public string MM_MailerDeliveryDetail_Notes{get;set;}
        public double MM_Mailers_Amount{get;set;}
        public double MM_Mailers_BefVATAmount{get;set;}
        public DateTime? MM_Mailers_AcceptDate{get;set;}
        public string MM_Mailers_CurrentPostOfficeID{get;set;}
        public string MM_Mailers_MailerDescription{get;set;}
        public string MM_Mailers_MailerTypeID{get;set;}
        public string MM_Mailers_PostOfficeAcceptID{get;set;}
        public double MM_Mailers_Quantity{get;set;}
        public string MM_Mailers_RecieverAddress{get;set;}
        public string MM_Mailers_RecieverProvinceID{get;set;}
        public DateTime? MM_Mailers_SalesClosingDate{get;set;}
        public string MM_Mailers_SenderID{get;set;}
        public string MM_Mailers_SenderName{get;set;}
        public string MM_Mailers_ServiceTypeID{get;set;}
        public string MM_Mailers_ThirdpartyDocID{get;set;}
        public double MM_Mailers_Weight{get;set;}
        public string MM_ReturnReason_ReturnReasonName{get;set;}
        public string MM_Status_StatusID{get;set;}
        public string MM_Status_StatusName { get; set; }
        public string MM_PackingListInternal_UserGroupSend { get; set; }
    }
    public class MailerPPNT
    {
        public double Weight { get; set; }
        public string PostOfficeAcceptID { get; set; }
        public string SenderName { get; set; }
        public string ProvinceID { get; set; }
        public decimal? Price { get; set; }
        public decimal? PriceService { get;set; }
        public DateTime? AcceptDate { get; set; }
        public double? CPNT { get; set; }
        public string Description { get; set; }
    }
    public class District
    {
        public string DistrictID { get; set; }
    }

    public class SpecialCustomer
    {
        public int ID { get; set; }
        public string FromPlace { get; set; }
        public string CGNumber { get; set; }
        public string SoChungTuThuVe { get; set; }
        public string SoChungTuLienQuan { get; set; }
        public string DeliveryDate { get; set; }
        public string NodeName { get; set; }
        public string ShiptoAddress { get; set; }
        public string Province { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Staff { get; set; }
        public string Note { get; set; }
        public string Zone { get; set; }
        public string CustomerID { get; set; }
        public string PostOffice { get; set; }
    }

    public class SpCustomer
    {
        public string Zone { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
    }

    public class HoaDon
    {
        public string SoCT { get; set; }
        public string SoHD { get; set; }
        public int ID { get; set; }
        public DateTime? CreateDate { get; set; }

    }

    public class ChiTietHoaDon
    {
        public string SoCT { get; set; }
        public string TenHangHoa { get; set; }
        public string SoCG { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? CuocDV { get; set; }
        public int? VAT { get; set; }
        public int? Total { get; set; }
        public int ID { get; set; }

    }

    public class getPostOfficeName
    {
        public string PostOfficeName { get; set; }
    }
    public class getPostOffice
    {
        public string PostOfficeID { get; set; }
        public string PostOfficeName { get; set; }
    }

    public class getUserName
    {
        public string UserName { get; set; }
    }

    public class Customers
    {
        public string CustomerID { get; set; }
    }
    public class CustomerGroup
    {
        public string GroupID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Taxcode { get; set; }
        public string ZoneID { get; set; }
    }

    public class SpeCustomer
    {
        public int ID { get; set; }
        public string PostOfficeID { get; set; }
        public string EmployeeID { get; set; }
        public string FromPlace { get; set; }
        public string CGNumber   { get; set; }
        public string SoChungTuThuVe { get; set; }
        public string NodeName { get; set; }
        public string ShiptoAddress { get; set; }
        public string DeliveryTo { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string Note { get; set; }
    }

    public class getSpCus
    {
        public string DeliveryTo { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
    }

    public class getCustomerIDTab4
    {
        public string CustomerID { get; set; }

    }

    public class getCustomerGroupTab4
    {
        public string CustomerGroupID { get; set; }
        public string CustomerGroupName { get; set; } 

    }

    public class getListSpCustomer
    {
        public string PostOfficeAcceptID { get; set; }
        public string SenderID { get; set; }
        public string SenderName { get; set; }
        public string MailerID { get; set; }
        public int Quantity { get; set; }
        public string ReceiveProvinceID { get; set; }
        public string RecieverAddress { get; set; }
        public string ServiceTypeID { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string DeliveryTo { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string AcceptDate { get; set; }
        public double? Weight { get; set; }
        public string PostOfficeDelivery { get; set; }
        public string EmployeeName { get; set; }
    }
    public class CGChuaNhapDT
    {
        public string BC { get; set; }
        public string CG { get; set; }
        public string NgayNhan { get; set; }
        public int? SL { get; set; }
        public double? TL { get; set; }
        public double? TLKhoi { get; set; }
        public string NoiDen { get; set; }
    }
}