using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruckManage
{
    class TM
    {
        //get list of account
        public static IList<ACCOUNT> GetListOfAccount() {
            IList<ACCOUNT> rs;
            using (var httn = new TruckDataDataContext())
            {
                rs = httn.ACCOUNTs.ToList();
            }
            return rs;
        }

        //get list of driver
        public static IList<DRIVER> GetListOfDriver()
        {
            IList<DRIVER> rs;
            using (var httn = new TruckDataDataContext())
            {
                rs = httn.DRIVERs.ToList();
            }
            return rs;
        }

        //get list of admin
        public static IList<ADMINMN> GetListOfAdmin()
        {
            IList<ADMINMN> rs;
            using (var httn = new TruckDataDataContext())
            {
                rs = httn.ADMINMNs.ToList();
            }
            return rs;
        }

        //delete a driver
        public static bool DeleteDriver(int id) 
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                var rs = httn.DRIVERs.Where(s => s.ID == id);
                httn.DRIVERs.DeleteAllOnSubmit(rs);
                try
                {
                    httn.SubmitChanges();
                }
                catch (Exception)
                {
                    rt = false;
                }
            }
            return rt;
        }

        //delete a account
        public static bool DeleteAccount(int id)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                var rs = httn.ACCOUNTs.Where(s => s.ID == id);
                httn.ACCOUNTs.DeleteAllOnSubmit(rs);
                try
                {
                    httn.SubmitChanges();
                }
                catch (Exception)
                {
                    rt = false;
                }
            }
            return rt;
        }

        //update a driver
        public static bool UpdateInfoDriver(int id, string name, string idcard, string address, string phone)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                var rs = httn.DRIVERs.Where(s => s.ID == id).Select(s => s).SingleOrDefault();
                if (rs != null)
                {
                    rs.NAME = name;
                    rs.IDCARD = idcard;
                    rs.ADDRESS = address;
                    rs.PHONE = phone;
                    try
                    {
                        httn.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        rt = false;
                    }
                }
                else
                {
                    rt = false;
                }
            }
            return rt;
        }

        //update status account
        public static bool UpdateStatusAccount(int id, int status)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                var rs = httn.ACCOUNTs.Where(s => s.ID == id).Select(s => s).SingleOrDefault();
                if (rs != null)
                {
                    rs.STATUS = status;
                    try
                    {
                        httn.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        rt = false;
                    }
                }
                else
                {
                    rt = false;
                }
            }
            return rt;
        }

        //add a account
        public static bool AddAccount(string username, string password, int typeid, int status)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                int count = httn.ACCOUNTs.Count();
                ACCOUNT t = new ACCOUNT
                {
                    ID = count+1,
                    USERNAME = username,
                    PASSWORD = password,
                    TYPEID = typeid,
                    STATUS = status
                };
                httn.ACCOUNTs.InsertOnSubmit(t);
                try
                {
                    httn.SubmitChanges();
                }
                catch
                {
                    rt = false;
                }
            }
            return rt;
        }

        //add a driver
        public static bool AddDriver(int id, string name, string idcard, string address, string phone)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                DRIVER t = new DRIVER
                {
                    ID = id,
                    NAME = name,
                    IDCARD = idcard,
                    ADDRESS = address,
                    PHONE = phone
                };
                httn.DRIVERs.InsertOnSubmit(t);
                try
                {
                    httn.SubmitChanges();
                }
                catch
                {
                    rt = false;
                }
            }
            return rt;

        }

        //update password account
        public static bool UpdatePasswordAccount(int id, string pass)
        {
            bool rt = true;
            using (var httn = new TruckDataDataContext())
            {
                var rs = httn.ACCOUNTs.Where(s => s.ID == id).Select(s => s).SingleOrDefault();
                if (rs != null)
                {
                    rs.PASSWORD = pass;
                    try
                    {
                        httn.SubmitChanges();
                    }
                    catch (Exception)
                    {
                        rt = false;
                    }
                }
                else
                {
                    rt = false;
                }
            }
            return rt;
        }
    }
}
