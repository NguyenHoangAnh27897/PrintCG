﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintCG_24062016.DBLIST {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DBLIST.Service1Soap")]
    public interface Service1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Payment_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Payment_Insert(string paymentmethod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Payment_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Payment_Update(string paymentmethodID, string paymentmethod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Payment_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Payment_Delete(string paymentmethodID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customer_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Customer_Insert(string customerid, string customername, string taxcode, string accno, string address, string phonenumber, string faxnumber, string postofficeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customer_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Customer_Update(string customerid, string customername, string taxcode, string accno, string address, string phonenumber, string faxnumber, string postofficeid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customer_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Customer_Delete(string customerid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Invoices_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Invoices_Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Invoices_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Invoices_Insert(string BuyerID, string Date, int PaymentMethodID, int ServiceID, double Amount, string Month, string Description, string InvoiceNo, string PostOfficeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Invoices_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Invoices_Update(int id, string Description, double Amount, string Invoice);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seller_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Seller_Update(string sellerid, string sellername, string address, string faxnumber, string phonenumber, string accno, string taxcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Services_Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Services_Delete(int serviceid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Services_Insert", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Services_Insert(string servicename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Services_Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string Services_Update(int serviceid, string servicename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customers_GetMaxID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Customers_GetMaxID();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seller_Info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Seller_Info();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Invoices_Info", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Invoices_Info(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Services_Get", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Services_Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Payment_Get", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Payment_Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customers_Get", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Customers_Get(string PostOfficeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Invoices_Get", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Invoices_Get(string FromDate, string ToDate, string PostOfficeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Customers_GetID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Customers_GetID(string CustomerID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertDHLPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string InsertDHLPlan(
                    string DHLDO, 
                    string PGI, 
                    string DeliveryDate, 
                    string ToZone, 
                    string ZoneDesc, 
                    string ToNodeCode, 
                    string ShiptoNM, 
                    string ShiptoAddress, 
                    int Quatity, 
                    string Unit1, 
                    int Weight, 
                    string Unit2, 
                    string Subcon, 
                    string CG, 
                    int SL, 
                    int TL, 
                    string TP, 
                    string KH, 
                    string Unit3, 
                    string TongSL, 
                    string SenderName, 
                    string SenderAddress, 
                    string Contact1, 
                    string Contact2, 
                    string Contact3, 
                    string Employee, 
                    string Vung);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DHL_GetDO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet DHL_GetDO(string DODHL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InsertSonyPlan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        string InsertSonyPlan(
                    string DODate, 
                    string DODHL, 
                    string ShipToParty, 
                    string ShipToName, 
                    string ShipToStreet, 
                    string Province, 
                    double GrossWeight, 
                    double Quatity, 
                    string Remark, 
                    string TongSL, 
                    string Employee, 
                    string Contact1, 
                    string Contact2, 
                    string Contact3, 
                    string DeliveryDate, 
                    string ProvinceID, 
                    int SL, 
                    string CG, 
                    double TL, 
                    string SenderName, 
                    string SenderAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sony_GetDO", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet Sony_GetDO(string DODHL);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SGP_KT_GetPackingListbyMailerID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Data.DataSet SGP_KT_GetPackingListbyMailerID(string CG);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Service1SoapChannel : PrintCG_24062016.DBLIST.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<PrintCG_24062016.DBLIST.Service1Soap>, PrintCG_24062016.DBLIST.Service1Soap {
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Payment_Insert(string paymentmethod) {
            return base.Channel.Payment_Insert(paymentmethod);
        }
        
        public string Payment_Update(string paymentmethodID, string paymentmethod) {
            return base.Channel.Payment_Update(paymentmethodID, paymentmethod);
        }
        
        public string Payment_Delete(string paymentmethodID) {
            return base.Channel.Payment_Delete(paymentmethodID);
        }
        
        public string Customer_Insert(string customerid, string customername, string taxcode, string accno, string address, string phonenumber, string faxnumber, string postofficeid) {
            return base.Channel.Customer_Insert(customerid, customername, taxcode, accno, address, phonenumber, faxnumber, postofficeid);
        }
        
        public string Customer_Update(string customerid, string customername, string taxcode, string accno, string address, string phonenumber, string faxnumber, string postofficeid) {
            return base.Channel.Customer_Update(customerid, customername, taxcode, accno, address, phonenumber, faxnumber, postofficeid);
        }
        
        public string Customer_Delete(string customerid) {
            return base.Channel.Customer_Delete(customerid);
        }
        
        public string Invoices_Delete(int id) {
            return base.Channel.Invoices_Delete(id);
        }
        
        public string Invoices_Insert(string BuyerID, string Date, int PaymentMethodID, int ServiceID, double Amount, string Month, string Description, string InvoiceNo, string PostOfficeID) {
            return base.Channel.Invoices_Insert(BuyerID, Date, PaymentMethodID, ServiceID, Amount, Month, Description, InvoiceNo, PostOfficeID);
        }
        
        public string Invoices_Update(int id, string Description, double Amount, string Invoice) {
            return base.Channel.Invoices_Update(id, Description, Amount, Invoice);
        }
        
        public string Seller_Update(string sellerid, string sellername, string address, string faxnumber, string phonenumber, string accno, string taxcode) {
            return base.Channel.Seller_Update(sellerid, sellername, address, faxnumber, phonenumber, accno, taxcode);
        }
        
        public string Services_Delete(int serviceid) {
            return base.Channel.Services_Delete(serviceid);
        }
        
        public string Services_Insert(string servicename) {
            return base.Channel.Services_Insert(servicename);
        }
        
        public string Services_Update(int serviceid, string servicename) {
            return base.Channel.Services_Update(serviceid, servicename);
        }
        
        public System.Data.DataSet Customers_GetMaxID() {
            return base.Channel.Customers_GetMaxID();
        }
        
        public System.Data.DataSet Seller_Info() {
            return base.Channel.Seller_Info();
        }
        
        public System.Data.DataSet Invoices_Info(int id) {
            return base.Channel.Invoices_Info(id);
        }
        
        public System.Data.DataSet Services_Get() {
            return base.Channel.Services_Get();
        }
        
        public System.Data.DataSet Payment_Get() {
            return base.Channel.Payment_Get();
        }
        
        public System.Data.DataSet Customers_Get(string PostOfficeID) {
            return base.Channel.Customers_Get(PostOfficeID);
        }
        
        public System.Data.DataSet Invoices_Get(string FromDate, string ToDate, string PostOfficeID) {
            return base.Channel.Invoices_Get(FromDate, ToDate, PostOfficeID);
        }
        
        public System.Data.DataSet Customers_GetID(string CustomerID) {
            return base.Channel.Customers_GetID(CustomerID);
        }
        
        public string InsertDHLPlan(
                    string DHLDO, 
                    string PGI, 
                    string DeliveryDate, 
                    string ToZone, 
                    string ZoneDesc, 
                    string ToNodeCode, 
                    string ShiptoNM, 
                    string ShiptoAddress, 
                    int Quatity, 
                    string Unit1, 
                    int Weight, 
                    string Unit2, 
                    string Subcon, 
                    string CG, 
                    int SL, 
                    int TL, 
                    string TP, 
                    string KH, 
                    string Unit3, 
                    string TongSL, 
                    string SenderName, 
                    string SenderAddress, 
                    string Contact1, 
                    string Contact2, 
                    string Contact3, 
                    string Employee, 
                    string Vung) {
            return base.Channel.InsertDHLPlan(DHLDO, PGI, DeliveryDate, ToZone, ZoneDesc, ToNodeCode, ShiptoNM, ShiptoAddress, Quatity, Unit1, Weight, Unit2, Subcon, CG, SL, TL, TP, KH, Unit3, TongSL, SenderName, SenderAddress, Contact1, Contact2, Contact3, Employee, Vung);
        }
        
        public System.Data.DataSet DHL_GetDO(string DODHL) {
            return base.Channel.DHL_GetDO(DODHL);
        }
        
        public string InsertSonyPlan(
                    string DODate, 
                    string DODHL, 
                    string ShipToParty, 
                    string ShipToName, 
                    string ShipToStreet, 
                    string Province, 
                    double GrossWeight, 
                    double Quatity, 
                    string Remark, 
                    string TongSL, 
                    string Employee, 
                    string Contact1, 
                    string Contact2, 
                    string Contact3, 
                    string DeliveryDate, 
                    string ProvinceID, 
                    int SL, 
                    string CG, 
                    double TL, 
                    string SenderName, 
                    string SenderAddress) {
            return base.Channel.InsertSonyPlan(DODate, DODHL, ShipToParty, ShipToName, ShipToStreet, Province, GrossWeight, Quatity, Remark, TongSL, Employee, Contact1, Contact2, Contact3, DeliveryDate, ProvinceID, SL, CG, TL, SenderName, SenderAddress);
        }
        
        public System.Data.DataSet Sony_GetDO(string DODHL) {
            return base.Channel.Sony_GetDO(DODHL);
        }
        
        public System.Data.DataSet SGP_KT_GetPackingListbyMailerID(string CG) {
            return base.Channel.SGP_KT_GetPackingListbyMailerID(CG);
        }
    }
}