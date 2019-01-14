using System;

namespace DAL
{
    public class Factory
    {
        static DAL.Idal dal;
        static public Idal GetDAL()
        {
            if (dal == null) dal = new DAL.Dal_imp();
            return dal;
        }
    }
}