using System;

namespace DAL
{
    internal class Factory
    {
        static DAL.Idal dal;
        internal static Idal GetDAL()
        {
            if (dal == null) dal = new DAL.Dal_imp();
            return dal;
        }
    }
}