using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SGPWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SGPService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SGPService.svc or SGPService.svc.cs at the Solution Explorer and start debugging.
    public class SGPService : ISGPService
    {
        private DB.SGPAPIDataContext api = new DB.SGPAPIDataContext(); //PMS-TEST
        private DB.SGPMainDataContext pms = new DB.SGPMainDataContext(); //SGPAPI
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
            List<DB.BS_Province> data = pms.BS_Provinces.Where(t => t.IsActive ==true && t.ProvinceID.Length ==3).ToList();
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
            }else
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
        public bool insertSGP_Price_Policy(string PriceID, string PostOfficeID, string Type, DateTime CreateDate, int Status, int Service, string Description, string ZoneID,string CalPrice)
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
            }catch
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
                    TW= TW,
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
            List<DB.SGP_Price_Customer> data = api.SGP_Price_Customers.Where(t =>t.PriceID == PriceID).ToList();
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
        public List<DataClass.PriceList> calPrice(int Quantity, float Weight, string ProvinceID, string CustomerID, string ServiceType)
        {
            //can xác dinh kh có bảng giả hay không
            //xac dinh loai bang gia
            //xac dinh trong luong
            //xac dinh nac trong luong
            //tinh gia
            List<DataClass.PriceList> list = new List<DataClass.PriceList>();
            string PriceID = string.Empty;
            var query = (from post in api.SGP_Price_Customers
                        join meta in api.SGP_Price_Services on post.PriceID equals meta.PriceID
                        where post.CustomerID == CustomerID && meta.ServiceID == ServiceType
                        select new { post.PriceID }).FirstOrDefault();
            PriceID = query.PriceID;
            if (PriceID != string.Empty) // neu lon hon 0 thi có bang giá
            {
                var zoneid = api.SGP_Price_Policies.Where(m => m.PricePolicyID == PriceID).FirstOrDefault();
                var zone = api.SGP_Province_Zones.Where(t => t.ZoneID == zoneid.ZoneID && t.ProvinceID == ProvinceID).FirstOrDefault();
                var nactl = api.SGP_Price_Values.Where(t => t.PriceID == PriceID && (t.FW<= Weight && t.TW >= Weight) && t.Zone == zone.Zone).FirstOrDefault();
                if(nactl != null)
                {
                    list.Add(new DataClass.PriceList()
                        {
                            Price = float.Parse(nactl.Price.Value.ToString()),
                            PriceService = 0
                        });
                }
            }
            return list;

        }
        public List<DB.Tools_Tracking> getUserTrackingProfile(string User)
        {
            var userprofife = api.Tools_Trackings.Where(m => m.UserName == User).ToList();
            if(userprofife != null)
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
                         join mdd in pms.MM_MailerDeliveryDetails on m.MailerID equals mdd.MailerID
                         join pid in pms.MM_PackingListInternalDetails on m.MailerID equals pid.MailerID
                         join pi in pms.MM_PackingListInternals on pid.DocumentID equals pi.DocumentID
                         join md in pms.MM_MailerDeliveries on mdd.DocumentID equals md.DocumentID
                         join e in pms.BS_Employees on md.EmployeeID equals e.EmployeeID
                         join s in pms.MM_Status on m.CurrentStatusID equals s.StatusID
                         join r in pms.MM_ReturnReasons on mdd.ReturnReasonID equals r.ReturnReasonID
                         where m.MailerID == MailerID orderby mdd.ID descending
                         select new DataClass.Trackings()
                         {
                             BS_Employees_EmployeeID = e.EmployeeID,
                         }).ToList();
            return query;
        }
    }
}
