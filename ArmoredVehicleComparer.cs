using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormAAG
{
    public class ArmoredVehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is AntiAircraftGun && (y is ArmoredVehicle && !(y is AntiAircraftGun)))
            return 1;
            else if ((x is ArmoredVehicle && !(x is AntiAircraftGun)) && y is AntiAircraftGun)
            return -1;
            else if (x is AntiAircraftGun && y is AntiAircraftGun)
            return ComparerAntiAircraftGun((AntiAircraftGun)x, (AntiAircraftGun)y);
            else return ComparerArmoredVehicle((ArmoredVehicle)x, (ArmoredVehicle)y);
            
        }
        private int ComparerArmoredVehicle(ArmoredVehicle x, ArmoredVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerAntiAircraftGun(AntiAircraftGun x, AntiAircraftGun y)
        {
            var res = ComparerArmoredVehicle(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Gun != y.Gun)
            {
                return x.Gun.CompareTo(y.Gun);
            }
            if (x.Radiolocation != y.Radiolocation)
            {
                return x.Radiolocation.CompareTo(y.Radiolocation);
            }
            return 0;
        }
    }
}
