using System;

namespace MedShop
{
    public class DelvryService
    {
        public bool IsDlvrySvcAvlbl(int slot)
        {
            if (slot < 5)
            {
                return false;
            }

            return true;

        }
    }
}
