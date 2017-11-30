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
}