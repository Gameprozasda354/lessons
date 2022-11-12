using System;

namespace HomeworkOfInheritance
{
    public class BaseClass
    {
        public static int counter = 1;

        private int _id;

        public int Id
        {
            get
            {
                return this._id;
            }
            private set {

            }
        }

        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int EditUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }
        public bool IsDeleted { get; set; }

        public BaseClass()
        {
            _id = counter;
            counter++;
        }
    }
}
