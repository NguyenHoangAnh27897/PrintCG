using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using SGPWebService.DataClass;

namespace SGPWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SGPService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SGPService.svc or SGPService.svc.cs at the Solution Explorer and start debugging.
    public class SGPService : ISGPService
    {
        private DB.SGPAPIDataContext api = new DB.SGPAPIDataContext();  //API
        private DB.SGPMainDataContext pms = new DB.SGPMainDataContext(); //PMS-TEST
        private DB.DBLISTEntities dbl = new DB.DBLISTEntities();  //DBLIST
        private DB.SGPAPIEntities sgpapi = new DB.SGPAPIEntities();
        public bool login(string user, string pass, string post)
        {
            bool flag = false;
            string ps = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(pass, "SHA1");
            var count = pms.UMS_tblUserAccounts.Where(me => me.UserGroupID == user && me.Password == ps).Count();
            if (count == 1)
            {
                var cpost = pms.UMS_tblUserAccountPostOffices.Where(p => p.UserGroupID == user && p.PostOfficeID == post).Count();
                if (cpost >= 1)
                {
                    return true; ;
                }
            }
            return flag;
        }
        public string getmaxMailerID(string postoffice)
        {
            //postoffice = "SGP";
            string str = "";
            string newStr = "";
            try
            {
                var maxid = api.PMS_MaxMailerIDs.Where(t => t.PostOfficeID == postoffice).First();
                if (maxid.MaxID != "" && maxid != null)
                {
                    str = maxid.MaxID.ToString();
                    string batdau = str.Substring(0, postoffice.Length);
                    string ketthuc = str.Substring(postoffice.Length, 9);
                    newStr = batdau + (int.Parse(ketthuc) + 1).ToString("D9");

                    maxid.MaxID = newStr;
                    api.SubmitChanges();
                }
                else
                {
                    newStr = postoffice + "000000001";
                }
                return newStr;
            }
            catch
            {
                newStr = postoffice + "000000001";
                return newStr;
            }
        }

        public List<DB.BS_Province> getProvince()
        {
            List<DB.BS_Province> data = pms.BS_Provinces.Where(t => t.IsActive == true && t.ProvinceID.Length == 3).ToList();
            return data;
        }
        public bool insertSGP_Province_Zones(string ZoneID, string ProvinceID, int Zone)
        {
            //kiem tra neu zoneid + province da ton tai thi update, neu khong moi insert
            var zone = api.SGP_Province_Zones.Where(p => p.ZoneID == ZoneID && p.ProvinceID == ProvinceID).FirstOrDefault();
            if (zone != null)
            {
                zone.ZoneID = ZoneID;
                zone.ProvinceID = ProvinceID;
                zone.Zone = Zone;
                api.SubmitChanges();
                return true;
            }
            else
            {
                var pl = new DB.SGP_Province_Zone()
                {
                    ZoneID = ZoneID,
                    ProvinceID = ProvinceID,
                    Zone = Zone
                };
                api.SGP_Province_Zones.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
        }

        public List<DB.MM_ServiceType> getServiceType()
        {
            List<DB.MM_ServiceType> data = pms.MM_ServiceTypes.Where(t => t.IsActive == true).ToList();
            return data;
        }

        public List<DB.MM_Customer> getCustomer(string PostOfficeID)
        {
            List<DB.MM_Customer> data = pms.MM_Customers.Where(t => t.IsActive == true && t.PostOfficeID == PostOfficeID).ToList();
            return data;
        }

        public List<DataClass.ZoneList> getZoneList()
        {
            var query = (from ds in api.SGP_Province_Zones
                         select new DataClass.ZoneList()
                         {
                             ZoneID = ds.ZoneID,
                         }).Distinct();
            return query.ToList();

        }
        public int getmaxZone(string ZoneID)
        {
            var maxid = api.SGP_Province_Zones.OrderByDescending(x => x.Zone).Where(t => t.ZoneID == ZoneID).First();
            return int.Parse(maxid.Zone.ToString());

        }
        public bool insertSGP_Price_Policy(string PriceID, string PostOfficeID, string Type, DateTime CreateDate, int Status, int Service, string Description, string ZoneID, string CalPrice)
        {
            try
            {
                var pl = new DB.SGP_Price_Policy()
                {
                    PricePolicyID = PriceID,
                    PostOfficeID = PostOfficeID,
                    Type = Type,
                    CreateDate = CreateDate,
                    Status = Status,
                    Service = Service,
                    Description = Description,
                    ZoneID = ZoneID,
                    CalPrice = CalPrice
                };
                api.SGP_Price_Policies.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool insertSGP_Price_Customer(string PriceID, string CustomerID)
        {
            try
            {
                var pl = new DB.SGP_Price_Customer()
                {
                    PriceID = PriceID,
                    CustomerID = CustomerID
                };
                api.SGP_Price_Customers.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool insertSGP_Price_Service(string PriceID, string ServiceID)
        {
            try
            {
                var pl = new DB.SGP_Price_Service()
                {
                    PriceID = PriceID,
                    ServiceID = ServiceID
                };
                api.SGP_Price_Services.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool insertSGP_Price_Value(string PriceID, float FW, float TW, int Zone, float Price, int CalType, int RowIndex, int ColumnIndex)
        {
            try
            {
                var pl = new DB.SGP_Price_Value()
                {
                    PriceID = PriceID,
                    FW = FW,
                    TW = TW,
                    Zone = Zone,
                    Price = Price,
                    Type = CalType,
                    RowIndex = RowIndex,
                    ColumnIndex = ColumnIndex
                };
                api.SGP_Price_Values.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<DB.SGP_Price_Policy> getPricePolicy()
        {
            List<DB.SGP_Price_Policy> data = api.SGP_Price_Policies.ToList();
            return data;
        }
        public List<DB.SGP_Price_Customer> getPriceCustomer(string PriceID)
        {
            List<DB.SGP_Price_Customer> data = api.SGP_Price_Customers.Where(t => t.PriceID == PriceID).ToList();
            return data;
        }
        public List<DB.SGP_Price_Service> getPriceService(string PriceID)
        {
            List<DB.SGP_Price_Service> data = api.SGP_Price_Services.Where(t => t.PriceID == PriceID).ToList();
            return data;
        }
        public List<DB.SGP_Price_Value> getPriceValue(string PriceID)
        {
            List<DB.SGP_Price_Value> data = api.SGP_Price_Values.Where(t => t.PriceID == PriceID).ToList();
            return data;
        }
        public List<DataClass.PriceList> calPrice(int Quantity, float Weight, string ProvinceID, string CustomerID, string ServiceType, float Price)
        {
            //can xác dinh kh có bảng giả hay không
            //xac dinh loai bang gia
            //xac dinh trong luong
            //xac dinh nac trong luong
            //tinh gia
            float price = 0;
            float priceservice = 0;
            float ppxd = 0;
            float pphk = 0;
            List<DataClass.PriceList> list = new List<DataClass.PriceList>();
            string PriceID = string.Empty;
            var query = (from post in api.SGP_Price_Customers
                         join meta in api.SGP_Price_Services on post.PriceID equals meta.PriceID
                         where post.CustomerID == CustomerID && meta.ServiceID == ServiceType
                         select new { post.PriceID }).FirstOrDefault();
            if (query == null)
            {
                price = Price;
            }
            else
            {
                PriceID = query.PriceID;
                var zoneid = api.SGP_Price_Policies.Where(m => m.PricePolicyID == PriceID).FirstOrDefault();
                var zone = api.SGP_Province_Zones.Where(t => t.ZoneID == zoneid.ZoneID && t.ProvinceID == ProvinceID).FirstOrDefault();
                var nactl = api.SGP_Price_Values.Where(t => t.PriceID == PriceID && (t.FW <= Weight && t.TW >= Weight) && t.Zone == zone.Zone).FirstOrDefault();
                if (PriceID != string.Empty) // neu lon hon 0 thi có bang giá
                {
                    if (nactl != null)//neu nam trong khoang 2000 gram
                    {
                        price = float.Parse(nactl.Price.Value.ToString());
                    }
                    else
                    {
                        var nactltt = api.SGP_Price_Values.Where(t => t.PriceID == PriceID && t.FW == t.TW && t.Zone == zone.Zone).FirstOrDefault();
                        var cuoc2kg = api.SGP_Price_Values.Where(t => t.PriceID == PriceID && t.TW == 2000 && t.Zone == zone.Zone).FirstOrDefault();
                        if (Weight > 2000)
                        {
                            //sua code
                            float tlthua = Weight - 2000;
                            if (tlthua <= 500)
                            {
                                price = float.Parse((nactltt.Price + cuoc2kg.Price).ToString());
                            }
                            else if (tlthua > 500)
                            {
                                double tile = (tlthua / 500);
                                float a = (tlthua % 500);
                                if (a > 0)
                                {
                                    tile = tile + 1;
                                }
                                price = float.Parse((cuoc2kg.Price + nactltt.Price * tile).ToString());
                            }
                            //sua code 


                        }
                    }
                }
                //them service neu co
                if (zoneid.Service == 1)
                {
                    var pp_xd = api.SGP_Price_Service_Values.Where(t => t.PriceID == PriceID && t.Service == "PPXD" && t.Zone == zone.Zone).FirstOrDefault();
                    var pp_hk = api.SGP_Price_Service_Values.Where(t => t.PriceID == PriceID && t.Service == "PPHK" && t.Zone == zone.Zone).FirstOrDefault();
                    //ppxd
                    ppxd = float.Parse((pp_xd.Price / 100 * price).ToString());
                    //pphk
                    if (Weight > pp_hk.ConditionApply)
                    {
                        float nachk = float.Parse(Math.Round(Weight / pp_hk.Weight, 0, MidpointRounding.AwayFromZero).ToString());
                        float a = float.Parse((Weight % pp_hk.Weight).ToString());
                        if (a > 0)
                        {
                            nachk = nachk + 1;
                        }
                        pphk = float.Parse((nachk * pp_hk.Price).ToString());
                    }
                    priceservice = ppxd + pphk;
                }
                //them gia vao class
            }
            
           
           
            list.Add(new DataClass.PriceList()
            {
                Price = price,
                PriceService = priceservice,
                PPXD = ppxd,
                PPHK = pphk
            });
            return list;

        }
        public List<DB.Tools_Tracking> getUserTrackingProfile(string User)
        {
            var userprofife = api.Tools_Trackings.Where(m => m.UserName == User).ToList();
            if (userprofife != null)
            {
                return userprofife;
            }
            else
            {
                var sysuser = api.Tools_Trackings.Where(m => m.UserName == "sys").ToList();
                return sysuser;
            }
        }
        public List<DataClass.Trackings> ToolTracking(string MailerID)
        {
            var query = (from m in pms.MM_Mailers
                         from mdd in pms.MM_MailerDeliveryDetails
                             .Where(mdds => mdds.MailerID == m.MailerID).DefaultIfEmpty()
                         from pid in pms.MM_PackingListInternalDetails
                             .Where(pids => pids.MailerID == m.MailerID).DefaultIfEmpty()
                         from pi in pms.MM_PackingListInternals
                            .Where(pids => pids.DocumentID == pid.DocumentID).DefaultIfEmpty()
                         from md in pms.MM_MailerDeliveries
                             .Where(pids => pids.DocumentID == mdd.DocumentID).DefaultIfEmpty()
                         from e in pms.BS_Employees
                              .Where(pids => pids.EmployeeID == md.EmployeeID).DefaultIfEmpty()
                         from s in pms.MM_Status
                             .Where(pids => pids.StatusID == m.CurrentStatusID).DefaultIfEmpty()
                         from r in pms.MM_ReturnReasons
                             .Where(pids => pids.ReturnReasonID == mdd.ReturnReasonID).DefaultIfEmpty()
                         where m.MailerID == MailerID
                         orderby mdd.ID descending
                         select new DataClass.Trackings()
                         {
                             MM_MailerDeliveryDetail_DeliveryTo = mdd.DeliveryTo,
                             MM_MailerDeliveryDetail_DeliveryDate = mdd.DeliveryDate,
                             MM_MailerDeliveryDetail_DeliveryTime = mdd.DeliveryDate,
                             BS_Employees_EmployeeID = e.EmployeeID,
                             BS_Employees_EmployeeName = e.EmployeeName,
                             MM_MailerDelivery_Description = md.Description,
                             MM_MailerDelivery_DocumentDate = md.DocumentDate,
                             MM_MailerDelivery_DocumentID = md.DocumentID,
                             MM_MailerDelivery_DocumentTime = md.DocumentTime,
                             MM_MailerDelivery_PostOfficeID = md.PostOfficeID,
                             MM_MailerDelivery_TripNumber = md.TripNumber,
                             MM_MailerDeliveryDetail_ConfirmDate = mdd.ConfirmDate,
                             MM_MailerDeliveryDetail_ConfirmIndex = mdd.ConfirmIndex,
                             MM_MailerDeliveryDetail_DeliveryNotes = mdd.DeliveryNotes,
                             MM_MailerDeliveryDetail_DeliveryStatus = mdd.DeliveryStatus,
                             MM_MailerDeliveryDetail_Notes = mdd.Notes,
                             MM_Mailers_Amount = double.Parse(m.Amount.ToString()),
                             MM_Mailers_BefVATAmount = double.Parse(m.BefVATAmount.ToString()),
                             MM_Mailers_AcceptDate = m.AcceptDate,
                             MM_Mailers_CurrentPostOfficeID = m.CurrentPostOfficeID,
                             MM_Mailers_MailerDescription = m.MailerDescription,
                             MM_Mailers_MailerTypeID = m.MailerTypeID,
                             MM_Mailers_PostOfficeAcceptID = m.PostOfficeAcceptID,
                             MM_Mailers_Quantity = m.Quantity,
                             MM_Mailers_RecieverAddress = m.RecieverAddress,
                             MM_Mailers_RecieverProvinceID = m.ReceiveProvinceID,
                             MM_Mailers_SalesClosingDate = m.SalesClosingDate,
                             MM_Mailers_SenderID = m.SenderID,
                             MM_Mailers_SenderName = m.SenderName,
                             MM_Mailers_ServiceTypeID = m.ServiceTypeID,
                             MM_Mailers_ThirdpartyDocID = m.ThirdpartyDocID,
                             MM_Mailers_Weight = m.Weight,
                             MM_ReturnReason_ReturnReasonName = r.ReturnReasonName,
                             MM_Status_StatusID = s.StatusID,
                             MM_Status_StatusName = s.StatusName,
                             MM_PackingListInternal_UserGroupSend = pi.UserGroupSend
                         }).ToList();
            return query;
        }

        public List<DB.SGP_Price_Service_Value> getPriceServiceValue(string PriceID)
        {
            List<DB.SGP_Price_Service_Value> data = api.SGP_Price_Service_Values.Where(t => t.PriceID == PriceID).ToList();
            return data;
        }

        public List<DataClass.MailerPPNT> getMailer(string MailerID)
        {
            var query = (from ds in pms.MM_Mailers
                         from mdd in pms.SGP_ChiPhis
                            .Where(mdds => mdds.cg == ds.MailerID).DefaultIfEmpty()
                         where ds.MailerID == MailerID
                         select new DataClass.MailerPPNT()
                         {
                             Weight = ds.Weight,
                             PostOfficeAcceptID = ds.PostOfficeAcceptID,
                             SenderName = ds.SenderName,
                             ProvinceID = ds.ReceiveProvinceID,
                             Price = ds.Price,
                             PriceService = ds.PriceService,
                             AcceptDate = ds.AcceptDate,
                             CPNT = mdd.cpnt,
                             Description = ds.MailerDescription,

                         });
            return query.ToList();
        }

        public List<DataClass.District> getDisitrct(string ProvinceID)
        {
            var query = (from ds in pms.BS_Districts
                         where ds.ProvinceID == ProvinceID
                         select new DataClass.District()
                         {
                             DistrictID = ds.DistrictID,

                         });
            return query.ToList();
        }

        public bool insertSGP_ChiPhi(string ctvphat, DateTime ngay, string cg, double tl, string lh, string noiden, double cptt, double cpnt, string bcchapnhan, string khachang, double cuoc, double phuphi, string quan, DateTime ngaynhan, string tinh, string bcnhan)
        {
            try
            {
                var pl = new DB.SGP_ChiPhi()
                {
                    ctvphat = ctvphat,
                    ngay = ngay,
                    cg = cg,
                    tl = tl,
                    loaihang = lh,
                    noiden = noiden,
                    cptt = cptt,
                    cpnt = cpnt,
                    bcchapnhan = bcchapnhan,
                    khachhang = khachang,
                    cuocchinh = cuoc,
                    phuphi = phuphi,
                    quan = quan,
                    ngaynhan = ngaynhan,
                    tinh = tinh,
                    bcnhap = bcnhan,
                };
                pms.SGP_ChiPhis.InsertOnSubmit(pl);
                pms.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<DB.SGP_ChiPhi> getCPNT(DateTime FromDate, DateTime ToDate, int type, string Post)
        {
            if (type == 0) //lay theo ngay nhap
            {
                List<DB.SGP_ChiPhi> data = pms.SGP_ChiPhis.Where(t => (t.ngay >= FromDate.Date && t.ngay <= ToDate.Date) && t.bcnhap == Post).ToList();
                return data;
            }
            else // lay theo ngay cg
            {
                List<DB.SGP_ChiPhi> data = pms.SGP_ChiPhis.Where(t => (t.ngaynhan >= FromDate.Date && t.ngaynhan <= ToDate.Date) && t.bcnhap == Post).ToList();
                return data;
            }
        }
        public bool addCustomer(string noigui, string socg, string sochungtuthuve, string sochungtulienquan, string deliverydate, string nodename, string shiptoaddress, string province, string zone, string customerid, string date, string hour, string staff, string note, string buucuc)
        {
            try
            {
                var rs = new DB.SGP_SpecialCustomer()
                {
                    FromPlace = noigui,
                    CGNumber = socg,
                    SoChungTuThuVe = sochungtuthuve,
                    SoChungTuLienQuan = sochungtulienquan,
                    DeliveryDate = deliverydate,
                    NodeName = nodename,
                    ShiptoAddress = shiptoaddress,
                    Province = province,
                    Date = date,
                    Hour = hour,
                    Staff = staff,
                    Note = note,
                    Zone = zone,
                    CustomerID = customerid,
                   PostOffice = buucuc
                };
                api.SGP_SpecialCustomers.InsertOnSubmit(rs);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool changeCustomer(int id, string date, string hour, string deliveryto)
        {
            try
            {
                var query = api.SGP_SpecialCustomers.FirstOrDefault(s=>s.ID == id);
                query.Date = date;
                query.Hour = hour;
                query.DeliveryTo = deliveryto;
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DataClass.SpCustomer> getCustomerID()
        {
            var query = (from cus in api.SGP_CustomerWithZones
                         select new DataClass.SpCustomer()
                         { 
                         CustomerID = cus.CustomerID,
                         CustomerName = cus.CustomerName
                         });
            return query.ToList();
        }

        public List<DataClass.SpeCustomer> getSpCustomer(string buucuc, string employee, string fromdate,string todate,int type) 
        {
            var parafrom = new SqlParameter("@FromDate", fromdate);
            var parato = new SqlParameter("@ToDate", todate);
            var palaemploy = new SqlParameter("@EmployeeID", employee);
            var parabuucuc = new SqlParameter("@PostOffice", buucuc);
            var paraloai = new SqlParameter("@Type", type);
            List<DataClass.SpeCustomer> list = new List<DataClass.SpeCustomer>();
            var result = sgpapi.Database.SqlQuery<DataClass.SpeCustomer>("SGP_WEB_SpecialCustomer @FromDate,@ToDate,@EmployeeID,@PostOffice,@Type", parafrom, parato, palaemploy, parabuucuc, paraloai).ToList();
            foreach (var item in result)
            {
                list.Add(new DataClass.SpeCustomer()
                {
                    ID = item.ID,//6
                    EmployeeID = item.EmployeeID,//3
                    FromPlace = item.FromPlace,//4
                    CGNumber = item.CGNumber,//0
                    SoChungTuThuVe = item.SoChungTuThuVe,//10
                    NodeName = item.NodeName,//7
                    ShiptoAddress = item.ShiptoAddress,//9
                    DeliveryTo = item.DeliveryTo,//2    
                    Date = item.Date,//1
                    Hour = item.Hour,//5
                    Note = item.Note,//8
                    PostOfficeID = item.PostOfficeID//11
                });
            }
            return list;
        }

        public bool addCustomerID(string zoneid, string customerid, string customername) 
        {
            try
            {
                var result = new DB.SGP_CustomerWithZone()
                {
                    ZoneID = zoneid,
                    CustomerID = customerid,
                    CustomerName = customername
                };
                api.SGP_CustomerWithZones.InsertOnSubmit(result);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addChiTietHoaDon(string soCT, DateTime createdate, string soCG, int cuocDV, int vat, int total, string tenhanghoa)
        {
            try
            {
                var result = new DB.SGP_ChiTietHoaDon()
                {
                    SoCT = soCT,
                    CreateDate = createdate,
                    CGNumber =soCG,
                    CuocDV = cuocDV,
                    VAT = vat,
                    Total = total,
                    PackageName = tenhanghoa
                };
                api.SGP_ChiTietHoaDons.InsertOnSubmit(result);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool addHoaDon(string soCT, string soHD, DateTime createdate)
        {
            try
            {
                var result = new DB.SGP_HoaDon()
                {
                    SoCT = soCT,
                    InvoiceNumber = soHD,
                    CreateDate = createdate
                };
                api.SGP_HoaDons.InsertOnSubmit(result);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DataClass.HoaDon> getHoaDon(DateTime Fromdate, DateTime Todate)
        {
            var query = (from hd in api.SGP_HoaDons
                         where (hd.CreateDate >= Fromdate && hd.CreateDate <= Todate) 
                         select new DataClass.HoaDon()
                         {
                            SoCT = hd.SoCT,
                            SoHD = hd.InvoiceNumber,
                            CreateDate = hd.CreateDate
                         });
            return query.Distinct().ToList();
        }

        public List<DataClass.ChiTietHoaDon> getChiTietHoaDon(string soCT)
        {
            var query = (from cthd in api.SGP_ChiTietHoaDons
                         where cthd.SoCT == soCT
                         select new DataClass.ChiTietHoaDon()
                         {
                             SoCT = cthd.SoCT,//5
                             SoCG = cthd.CGNumber,//4
                             CreateDate = cthd.CreateDate,//0
                             TenHangHoa = cthd.PackageName,//5
                             CuocDV = cthd.CuocDV,//1
                             VAT = cthd.VAT,//7
                             Total = cthd.Total,//6
                             ID = cthd.ID//2
                         });
            return query.ToList();
        }

        public string getPostOfficeName(string postofficeid)
        {
            var name = from po in pms.MM_PostOffices
                       where po.PostOfficeID == postofficeid
                       select po.PostOfficeName;
            string postname = name.FirstOrDefault();
            return postname;
        }

        public string getUserName(string userid)
        {
            var name = from po in pms.BS_Employees
                       where po.EmployeeID == userid
                       select po.EmployeeName;

            string username = name.FirstOrDefault();
            return username;
        }

        public List<DataClass.ChiTietHoaDon> getChiTietHoaDonAll()
        {
            var query = (from cthd in api.SGP_ChiTietHoaDons
                         select new DataClass.ChiTietHoaDon()
                         {
                             SoCT = cthd.SoCT,//5
                             SoCG = cthd.CGNumber,//3
                             CreateDate = cthd.CreateDate,//0
                             TenHangHoa = cthd.PackageName,//4
                             CuocDV = cthd.CuocDV,//1
                             VAT = cthd.VAT,//7
                             Total = cthd.Total,//6
                             ID = cthd.ID//2
                         });
            return query.ToList();
        }

        public List<DataClass.Customers> getCustomerIDbyPost(string PostOfficeID)
        {
            var query = (from ds in pms.MM_Customers
                         where ds.PostOfficeID == PostOfficeID
                         select new DataClass.Customers()
                         {
                             CustomerID = ds.CustomerID,

                         });
            return query.ToList();
        }


        public List<DataClass.CustomerGroup> getCustomerGroup()
        {
            var query = (from ds in api.SGP_CutomerGroups
                         select new DataClass.CustomerGroup()
                         {
                             GroupID = ds.GroupID,
                             Name = ds.GroupName,
                             Address = ds.Address,
                             Phone = ds.Phone,
                             Taxcode = ds.TaxCode,
                             ZoneID = ds.ZoneID,

                         });
            return query.ToList();
        }


        public List<DataClass.Customers> getCustomerIDbyGroup(string GroupID)
        {
            var query = (from ds in api.SGP_CustomerGroupDetails
                         where ds.GroupID == GroupID
                         select new DataClass.Customers()
                         {
                             CustomerID = ds.CustomerID,

                         });
            return query.ToList();
        }

        public List<DB.TB_DHLPlan> getDHLplan(DateTime FromDate, DateTime ToDate)
        {
            List<DB.TB_DHLPlan> data = dbl.TB_DHLPlan.Where(t => t.PGI >= FromDate.Date && t.PGI <= ToDate.Date).ToList();
            return data;
        }

        public bool updateMailerDeliveryDetail(string mailerid, DateTime ngaygio, string nguoinhan, string trangthai)
        {
            try
            {
                var query = pms.MM_MailerDeliveryDetails.Where(s => s.MailerID == mailerid).OrderByDescending(s=>s.ID).FirstOrDefault();
                query.DeliveryDate = ngaygio;
                query.DeliveryTo = nguoinhan;
                query.DeliveryStatus = trangthai;
                pms.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<DataClass.getCustomerIDTab4> getCustomerIDTab4(string postofficeid)
        {
            var query = (from ds in pms.MM_Customers
                         where ds.IsActive == true && ds.PostOfficeID == postofficeid
                         select new DataClass.getCustomerIDTab4()
                         {
                             CustomerID = ds.CustomerID

                         });
            return query.ToList();
        }

        public List<DataClass.getCustomerGroupTab4> getCustomerGroupTab4()
        {
            var query = (from ds in pms.MM_CustomerGroups
                         select new DataClass.getCustomerGroupTab4()
                         {
                             CustomerGroupID = ds.CustomerGroupID,
                             CustomerGroupName = ds.CustomerGroupName

                         });
            return query.ToList();
        }

        public List<DataClass.getListSpCustomer> getListSpCustomer(string tungay, string denngay, string customerid, string buucuc, int loai)
        {
            var parafrom = new SqlParameter("@FromDate", tungay);
            var parato = new SqlParameter("@ToDate", denngay);
            var paracustomer = new SqlParameter("@CustomerID", customerid);
            var parabuucuc = new SqlParameter("@PostOfficeID", buucuc);
            var paraloai = new SqlParameter("@Loai", loai);
            List<DataClass.getListSpCustomer> list = new List<DataClass.getListSpCustomer>();
            var result = sgpapi.Database.SqlQuery<DataClass.getListSpCustomer>("SGP_WEB_SpecialCustomerTab4 @FromDate,@ToDate,@CustomerID,@PostOfficeID,@Loai", parafrom, parato, paracustomer, parabuucuc, paraloai).ToList();
            foreach (var item in result)
            {
                list.Add(new DataClass.getListSpCustomer()
                {
                    PostOfficeAcceptID = item.PostOfficeAcceptID,
                    ReceiveProvinceID = item.ReceiveProvinceID,
                    RecieverAddress = item.RecieverAddress,
                    SenderName = item.SenderName,
                    Amount = item.Amount,
                    DeliveryDate = item.DeliveryDate,
                    DeliveryTo = item.DeliveryTo, 
                    MailerID = item.MailerID,
                    Price = item.Price,
                    Quantity = item.Quantity,
                    SenderID = item.SenderID,
                    ServiceTypeID = item.ServiceTypeID
                });
            }
            return list;
        }


        public List<DataClass.CGChuaNhapDT> getListCGChuaNhapDT(string tungay, string denngay, string buucuc)
        {
            var parafrom = new SqlParameter("@FromDate", tungay);
            var parato = new SqlParameter("@ToDate", denngay);
            var parabuucuc = new SqlParameter("@PostOfficeID", buucuc);
            List<DataClass.CGChuaNhapDT> list = new List<DataClass.CGChuaNhapDT>();
            var result = sgpapi.Database.SqlQuery<DataClass.CGChuaNhapDT>("SGP_WIN_CGChuaNhapDT @FromDate,@ToDate,@PostOfficeID", parafrom, parato, parabuucuc).ToList();           
            return result;
        }

        public List<DataClass.CGChuaNhapDT> getListCGChuaXuatBK(string tungay, string denngay, string buucuc)
        {
            var parafrom = new SqlParameter("@FromDate", tungay);
            var parato = new SqlParameter("@ToDate", denngay);
            var parabuucuc = new SqlParameter("@PostOfficeID", buucuc);
            List<DataClass.CGChuaNhapDT> list = new List<DataClass.CGChuaNhapDT>();
            var result = sgpapi.Database.SqlQuery<DataClass.CGChuaNhapDT>("SGP_WIN_CGChuaXuatBK @FromDate,@ToDate,@PostOfficeID", parafrom, parato, parabuucuc).ToList();
            return result;
        }
    
        public List<DataClass.getPostOffice> getPostOffice()
        {
            var query = (from ds in pms.MM_PostOffices
                         select new DataClass.getPostOffice()
                         {
                             PostOfficeID = ds.PostOfficeID,
                             PostOfficeName = ds.PostOfficeName

                         });
            return query.ToList();
        }


        public List<DB.MM_CustomerGroup> getCustomerGroupPMS()
        {            
            List<DB.MM_CustomerGroup> data = pms.MM_CustomerGroups.ToList();
            return data;
        }


        public List<DataClass.getListSpCustomer> getListCustomerGroupDetails(string tungay, string denngay, string parameter, string customergroup, int loai)
        {
            var parafrom = new SqlParameter("@FromDate", tungay);
            var parato = new SqlParameter("@ToDate", denngay);
            var parapara = new SqlParameter("@Parameter", parameter);
            var paracustomergroup = new SqlParameter("@CustomerGroupID", customergroup);
            var paraloai = new SqlParameter("@Loai", loai);
            List<DataClass.getListSpCustomer> list = new List<DataClass.getListSpCustomer>();
            var result = sgpapi.Database.SqlQuery<DataClass.getListSpCustomer>("SGP_WIN_SpecialCustomer @FromDate,@ToDate,@Parameter,@CustomerGroupID,@Loai", parafrom, parato, parapara, paracustomergroup, paraloai).ToList();
            //foreach (var item in result)
            //{
            //    list.Add(new DataClass.getListSpCustomer()
            //    {
            //        AcceptDate = item.AcceptDate,
            //        PostOfficeAcceptID = item.PostOfficeAcceptID,     
            //        ReceiveProvinceID = item.ReceiveProvinceID,
            //        RecieverAddress = item.RecieverAddress,
            //        SenderName = item.SenderName,
            //        Amount = item.Amount,
            //        DeliveryDate = item.DeliveryDate,
            //        DeliveryTo = item.DeliveryTo,
            //        MailerID = item.MailerID,
            //        Price = item.Price,
            //        Quantity = item.Quantity,
            //        Weight = item.Weight,
            //        SenderID = item.SenderID,
            //        ServiceTypeID = item.ServiceTypeID,
            //        PostOfficeDelivery = item.PostOfficeDelivery
            //    });
            //}
            return result;
        }

        public List<DataClass.ZoneList> getZone()
        {
            var query = (from ds in pms.MM_Zones
                         select new DataClass.ZoneList()
                         {
                             ZoneID = ds.ZoneID

                         });
            return query.ToList();
        }


        public List<DataClass.SpeCustomer> getMailerCustomerList(string buucuc, string employee, string fromdate, string todate, int type)
        {
            var parafrom = new SqlParameter("@FromDate", fromdate);
            var parato = new SqlParameter("@ToDate", todate);
            var palaemploy = new SqlParameter("@EmployeeID", employee);
            var parabuucuc = new SqlParameter("@PostOffice", buucuc);
            var paraloai = new SqlParameter("@Type", type);
            List<DataClass.SpeCustomer> list = new List<DataClass.SpeCustomer>();
            var result = sgpapi.Database.SqlQuery<DataClass.SpeCustomer>("SGP_WEB_SpecialCustomer @FromDate,@ToDate,@EmployeeID,@PostOffice,@Type", parafrom, parato, palaemploy, parabuucuc, paraloai).ToList();
            return result;
        }


        public bool insert_DocumentReturn(string DocumentID, DateTime DocumentDate, string POD,string PostOfficeID)
        {
            try
            {
                var pl = new DB.SGP_DocumentReturn()
                {
                    DocumentID = DocumentID,
                    DocumentDate = DocumentDate,
                    POD = POD,
                    PostOfficeID = PostOfficeID
                   
                };
                api.SGP_DocumentReturns.InsertOnSubmit(pl);
                api.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public List<DataClass.DocumentReturn> get_DocumentReturn(DateTime tungay, DateTime denngay, string buucuc)
        {
            var query = (from ds in api.SGP_DocumentReturns 
                         where ds.PostOfficeID == buucuc && ds.DocumentDate >= tungay.Date && ds.DocumentDate <= denngay.Date
                         select new DataClass.DocumentReturn()
                         {
                             PostOfficeID = ds.PostOfficeID,
                             DocumentID = ds.DocumentID,
                             POD = ds.POD,
                             DocumentDate = ds.DocumentDate

                         });
            return query.ToList();
        }


        public bool delete_DocumentReturn(string POD, string PostOfficeID)
        {
            DB.SGP_DocumentReturn dr = api.SGP_DocumentReturns.Single(t => t.PostOfficeID == PostOfficeID && t.POD == POD);
            if(dr != null)
            {
                api.SGP_DocumentReturns.DeleteOnSubmit(dr);
                api.SubmitChanges();
                return true;
            }else
            {
                return false;
            }
           
        }

        public List<DataClass.DocumentReturn> get_DocumentReturnbyPOD(string pod)
        {
            var query = (from ds in api.SGP_DocumentReturns
                         where ds.POD == pod
                         select new DataClass.DocumentReturn()
                         {
                             PostOfficeID = ds.PostOfficeID,
                             DocumentID = ds.DocumentID,
                             POD = ds.POD,
                             DocumentDate = ds.DocumentDate

                         });
            return query.ToList();
        }



        public DataClass.MM_Distances_procGetById getMM_Distances_procGetById(string postofficeid, string provinceid)
        {
            var parapost = new SqlParameter("@PostOfficeID", postofficeid);
            var paraprovince = new SqlParameter("@ProvinceID", provinceid);
            DataClass.MM_Distances_procGetById list = new DataClass.MM_Distances_procGetById();
            var result = sgpapi.Database.SqlQuery<DataClass.MM_Distances_procGetById>("MM_Distances_procGetById @PostOfficeID,@ProvinceID", parapost, paraprovince).FirstOrDefault();
            return result;
        }



        public DataClass.PriceMatrix getMM_PriceMatrix_procGetPriceData(string DocumentDate, string PostOfficeID, string ServiceTypeID, string CustomerID, string ProvinceID, int DistanceD, int PriceMatrixType, string PriceType, string ZoneID)
        {

            var paradocumentdate = new SqlParameter("@DocumentDate", DocumentDate);
            var parapost = new SqlParameter("@PostOfficeID", PostOfficeID);
            var paraservice = new SqlParameter("@ServiceTypeID", ServiceTypeID);
            var paracustomer = new SqlParameter("@CustomerID", CustomerID);
            var paraprovince = new SqlParameter("@ProvinceID", ProvinceID);
            var paradistance = new SqlParameter("@DistanceD", DistanceD);
            var parapricematrixtype = new SqlParameter("@PriceMatrixType", PriceMatrixType);
            var parapricetype = new SqlParameter("@PriceType", PriceType);
            var parazoneid = new SqlParameter("@ZoneID", ZoneID);
            DataClass.PriceMatrix list = new DataClass.PriceMatrix();
            var result = sgpapi.Database.SqlQuery<DataClass.PriceMatrix>("MM_PriceMatrix_procGetPriceData @DocumentDate,@PostOfficeID,@ServiceTypeID,@CustomerID,@ProvinceID,DistanceD,@PriceMatrixType,@PriceType,ZoneID", paradocumentdate, parapost, paraservice, paracustomer, paraprovince, paradistance, parapricematrixtype, parapricetype, parazoneid).FirstOrDefault();
            return result;
        }

        public List<PriceMaTrixDetails> getMM_PriceMatrix_procGetPriceDataDEtails(string DocumentDate, string PostOfficeID, string ServiceTypeID, string CustomerID, string ProvinceID, int DistanceD, int PriceMatrixType, string PriceType, string ZoneID)
        {
            var paradocumentdate = new SqlParameter("@DocumentDate", DocumentDate);
            var parapost = new SqlParameter("@PostOfficeID", PostOfficeID);
            var paraservice = new SqlParameter("@ServiceTypeID", ServiceTypeID);
            var paracustomer = new SqlParameter("@CustomerID", CustomerID);
            var paraprovince = new SqlParameter("@ProvinceID", ProvinceID);
            var paradistance = new SqlParameter("@DistanceD", DistanceD);
            var parapricematrixtype = new SqlParameter("@PriceMatrixType", PriceMatrixType);
            var parapricetype = new SqlParameter("@PriceType", PriceType);
            var parazoneid = new SqlParameter("@ZoneID", ZoneID);
            DataClass.PriceMaTrixDetails list = new DataClass.PriceMaTrixDetails();
            var result = sgpapi.Database.SqlQuery<DataClass.PriceMaTrixDetails>("MM_PriceMatrix_procGetPriceData @DocumentDate,@PostOfficeID,@ServiceTypeID,@CustomerID,@ProvinceID,DistanceD,@PriceMatrixType,@PriceType,ZoneID", paradocumentdate, parapost, paraservice, paracustomer, paraprovince, paradistance, parapricematrixtype, parapricetype, parazoneid).ToList();
            return result;
        }
    }
}
