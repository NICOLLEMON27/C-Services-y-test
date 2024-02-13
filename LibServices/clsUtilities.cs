using System;


namespace pkgServices
{
    public static class clsUtilities {
        public static T opAdd<T>(T prmOp1, T prmOp2) where T : struct, IConvertible
        {
            if (typeof(T) == typeof(double))
            {
                return (T)Convert.ChangeType(((double)Convert.ChangeType(prmOp1, typeof(double)) +
                    (double)Convert.ChangeType(prmOp2, typeof(double))), typeof(T));
            }
            if (typeof(T) == typeof(char))
            {
                return (T)Convert.ChangeType(((char)Convert.ChangeType(prmOp1, typeof(char)) +
                    (char)Convert.ChangeType(prmOp2, typeof(char))), typeof(T));
            }
                if (typeof(T) == typeof(int)) { 
                    return (T)Convert.ChangeType(((int)Convert.ChangeType(prmOp1, typeof(int)) +
                        (int)Convert.ChangeType(prmOp2, typeof(int))), typeof(T));
            }


            return default;
        }
    }
}
