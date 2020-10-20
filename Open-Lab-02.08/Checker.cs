using System;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            if(str == null)   
             return true;
            return string.IsNullOrEmpty(str);
        }
    } 
}
