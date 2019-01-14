using System;

namespace BL
{
    public class Factory
    {
        static BL.IBL bl;
        static public IBL GetBLL()
        {
            if (bl == null) bl = new BL.BL_imp();
            return bl;
        }
    }
}