// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("7Kt8btVtSqGOQ8lRBzsHj15WnE5FBe5gXcM9jogUDvH5vu8+c2cEMiWFjGitf0qTO63lRWohmXhJcYnjzRye8vwdqfxFgopSTcttPseRwVXDZrh+Eezo0soCM/wRmBB+yqTP8f4cUeyXJk852AZERhpw5hj6jtzxYTY+1+HQLFVEu2SIG37U5kyOwQI8X4yzW/7mNvowzcSTjPG+OpCz8GLh7+DQYuHq4mLh4eBpJtjAOZ8h0GLhwtDt5unKZqhmF+3h4eHl4OOavdB/7H+Ybs7bQGt03XJ4mBWWobVAaruoDrB0aPQto6DqFdR5rra1C3/JpXLrTPv6UlSTw6wSIeGRGLKiaRyXS1Fc//FUwdGxDlwxc9l942Plddav9p9YG+Lj4eDh");
        private static int[] order = new int[] { 12,10,3,9,5,5,7,8,10,12,10,12,12,13,14 };
        private static int key = 224;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
