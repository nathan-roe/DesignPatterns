using System;
namespace Learning
{
    public class Singleton
    {
        static Singleton Instance ;
        static Singleton _instance
        {
            get{return _instance;}
            set{_instance = value;}
        }

    }
}